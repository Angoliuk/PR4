using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Car : Vehicle
    {
        //Виніс спільний клас Vehicle, щоб менше писати
        //Тут ,по суті, нічого з нових властивостей немає, але колисть будуть
        public Car(
            float StartMaxFuelLevel = 50,
            float startFuelLevel = 20,
            float startFuelUsing = 1,
            float startDistance = 0
        )
        : base(
              StartMaxFuelLevel, 
              startFuelLevel, 
              startFuelUsing, 
              startDistance
        )
        {

        }
    }
}
