using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Spacecraft : Starship
    {
        private bool isCrewed { get; set; }

        public Spacecraft(
            int startXCoordinate = 0,
            int startYCoordinate = 0,
            int startTeamSize = 0,
            float startSpeed = 0,
            int startCreationYear = 2020,
            string startName = "ship",
            string startTeleportationModel = "Standart model V1.2 2490",
            string startEngineType = "SunEngine 3.5",
            bool startIsCrewed = false
        )
        : base(startXCoordinate, startYCoordinate, startTeamSize, startSpeed, startCreationYear, startName, startTeleportationModel, startEngineType)
        {
            isCrewed = startIsCrewed;
        }

    }
}
