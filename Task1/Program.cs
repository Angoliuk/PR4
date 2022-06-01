using System.Globalization;
using System.Text;
using Task1;

class Program
{
    public static void Main()
    {
        Random random = new Random();
        Ship ship = new Ship();

        ship.MoveUp();

        Console.WriteLine($"Ship y coordinate: {ship.yCoordinate}, x coordinate: {ship.xCoordinate}");

        Ship[] fleet = { 
            new Ship(0,1), 
            new Ship(1,2), 
            new Ship(2,3), 
            new Ship(3,4), 
            new Ship(4,5), 
            new Ship(5,6),
        };

        for (int i = 0; i < fleet.Length; i++)
        {
            if(random.Next(0, 10) > 5)
            {
                fleet[i].MoveUp();
                fleet[i].MoveUp();
            }

            Console.WriteLine(
                $"Fleet {fleet[i].name}, " +
                $"Team size: {fleet[i].teamSize}, " +
                $"Speed: {fleet[i].speed}, " +
                $"Creation date: {fleet[i].creationYear}, " +
                $"y: {fleet[i].yCoordinate}, " +
                $"x: {fleet[i].xCoordinate}" +
                $"\n"
            );
        }

        for (int i = 1;i < fleet.Length; i++)
        {
            Console.WriteLine($"Distance between first ship and ship {i}: {Math.Round(fleet[0].distanceCalc(fleet[i].xCoordinate, fleet[i].yCoordinate), 2)}");
        }

        PrintTimeStamp();

    }
    public static void PrintTimeStamp()
    {
        Console.OutputEncoding = Encoding.UTF8;
        DateTime localDate = DateTime.Now;
        var culture = new CultureInfo("ru-RU");
        Console.WriteLine("   Дата та час компіляції: {0}", localDate.ToString(culture));
        Console.WriteLine("   Автор: Анголюк Станіслав Дмитрович");
    }

}

