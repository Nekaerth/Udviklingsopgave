using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class Bicycle : Vehicle
    {
        public string Colour { get; }
        public double Weight { get; }

        public Bicycle()
        {
            Colour = "blue";
            Weight = 10;
        }
    }
}
