using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Vehicle
    {
        private float maxFuelLevel { get; set; }
        private float fuelLevel { get; set; }
        private float fuelUsing { get; set;}
        private float distance { get; set; }

        public Vehicle(
            float StartMaxFuelLevel = 50, 
            float startFuelLevel = 20, 
            float startFuelUsing = 1, 
            float startDistance = 0
        )
        {
            maxFuelLevel = StartMaxFuelLevel;
            fuelLevel = startFuelLevel > StartMaxFuelLevel ? 0 : startFuelLevel; 
            distance = startDistance;   
            fuelUsing = startFuelUsing;
        }

        public string FillUp(float fuelVolume)
        {
            if (fuelVolume < 0)
                return "Fuel may be positive num";
            if (maxFuelLevel - fuelLevel < fuelVolume)
                return "Too much fuel";
            fuelLevel += fuelVolume;
            return $"You refueled vehicle. Current fuel level is {fuelLevel}l.";
        }

        public string Drive(float travelDistance)
        {
            if(travelDistance < 0)
               return "Enter correct number";
            if (fuelLevel < (travelDistance / 100) * fuelUsing)
               return "Vehicle needs refueling";
            fuelLevel -= (travelDistance / 100) * fuelUsing;
            distance += travelDistance;
            return $"You travelled: {travelDistance} km\n" +
                   $"Total distance: {distance} km";
        }
    }
}
