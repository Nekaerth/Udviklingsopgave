using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VehicleLibrary;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            printVehicles();
            TestSearchFunction();
            saveInstances("instances.json");
        }

        static void printVehicles()
        {
            foreach (var vehicle in GetVehicles())
                Console.WriteLine(vehicle);
        }

        static IEnumerable<string> GetTypes(string query)
        {
            query = query.ToLower();
            return GetVehicles()
                .Where(x => x.ToLower().Contains(query));
        }

        private static IEnumerable<string> GetVehicles()
        {
            return new InstanceService().GetInstances<Vehicle>()
                .Select(x => x.GetType().Name)
                .OrderBy(x => x);
        }

        static void TestSearchFunction()
        {
            Console.WriteLine("Search for type");
            var input = Console.ReadLine();
            foreach (var type in GetTypes(input))
                Console.WriteLine(type);
        }

        static void saveInstances(string filePath)
        {
            var instances = new InstanceService().GetInstances<Vehicle>().ToList();
            WriteToJsonFile(filePath, instances);
        }

        private static void WriteToJsonFile<T>(string filePath, T objectToWrite) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(filePath, false);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
