using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Bus : Vehicle
    {
        //Виніс спільний клас Vehicle, щоб менше писати
        private int passengersNum { get; set; }
        public Bus(
            float StartMaxFuelLevel = 50,
            float startFuelLevel = 20,
            float startFuelUsing = 1,
            float startDistance = 0,
            int startPassengersNum = 0,
            float startFuelUseForConditioner = 1.4f
        )
        : base(
              StartMaxFuelLevel, 
              startFuelLevel, 
              startPassengersNum > 0 ? startFuelUsing + startFuelUseForConditioner : startFuelUsing, 
              startDistance
        )
        {
            passengersNum = startPassengersNum;
        }
    }
}
