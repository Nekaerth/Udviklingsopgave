using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class Train : Vehicle
    {
        public int MaxSpeed { get; }
        public int MaxPassengers { get; }

        public Train()
        {
            MaxSpeed = 300;
            MaxPassengers = 200;
        }
    }
}
