namespace Task1
{
    class Ship
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public int teamSize { get; set; }
        public float speed { get; set; }
        public int creationYear { get; set; }
        public string name { get; set; }

        public Ship(
            int startXCoordinate = 0,
            int startYCoordinate = 0,
            int startTeamSize = 0,
            float startSpeed = 0,
            int startCreationYear = 2020,
            string startName = "ship"
        )
        {
            xCoordinate = startXCoordinate;
            yCoordinate = startYCoordinate;
            teamSize = startTeamSize;
            name = startName;
            creationYear = startCreationYear;
            speed = startSpeed;
        }

        public void MoveUp()
        {
            yCoordinate++;
        }

        public double distanceCalc(int anotherShipX, int anotherShipY)
        {
            return Math.Sqrt(Math.Pow(anotherShipX - xCoordinate, 2) + Math.Pow(anotherShipY - yCoordinate, 2));
        }
    }
}
