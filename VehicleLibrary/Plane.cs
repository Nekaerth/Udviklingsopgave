using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class Plane : Vehicle
    {
        public double Cargo { get; }
        public double AircraftLength { get; }

        public Plane()
        {
            Cargo = 18;
            AircraftLength = 28;
        }
    }
}
