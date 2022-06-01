using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Destroyer : Spacecraft
    {
        private string ammoCalibre { get; set; }
        private float avgDamage { get; set; }
        private string[] defenceModules { get; set; }

        public Destroyer(
            string[] startDefenceModules, 
            int startXCoordinate = 0,
            int startYCoordinate = 0,
            int startTeamSize = 0,
            float startSpeed = 0,
            int startCreationYear = 2020,
            string startName = "ship",
            string startTeleportationModel = "Standart model V1.2 2490",
            string startEngineType = "SunEngine 3.5",
            bool startIsCrewed = false,
            string startAmmoCalibre = "139.5 T.Earth", 
            float startAvgDamage = 1
        ) 
        : base(startXCoordinate, startYCoordinate, startTeamSize, startSpeed, startCreationYear, startName, startTeleportationModel, startEngineType, startIsCrewed)
        {
            ammoCalibre = startAmmoCalibre;
            avgDamage = startAvgDamage;
            defenceModules = startDefenceModules;
        }
    }
}
