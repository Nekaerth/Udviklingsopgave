using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class Car : Vehicle
    {
        public int MaxSpeed { get; }
        public int Weight { get; }

        public Car()
        {
            MaxSpeed = 150;
            Weight = 900;
        }
    }
}
