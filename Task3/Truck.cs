using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Truck : Vehicle
    {
        //Виніс спільний клас Vehicle, щоб менше писати
        private float refuelLimit { get; set; }
        public Truck(
            float startMaxFuelLevel = 50, 
            float startFuelLevel = 20, 
            float startFuelUsing = 1, 
            float startDistance = 0, 
            float startRefuelLimit = 0.95f
        )
        : base(
              startMaxFuelLevel*startRefuelLimit, 
              startFuelLevel, 
              startFuelUsing, 
              startDistance
        )
        {
            refuelLimit = startRefuelLimit;
        }
    }
}
