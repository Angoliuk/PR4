using System.Globalization;
using System.Text;
using Task3;

class Program
{
    public static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        bool isPlaying = true;

        void CreateNewVehicle(string[] vehicleInfo)
        {
            if (
                !float.TryParse(vehicleInfo[1], out float maxFuelLevel) ||
                !float.TryParse(vehicleInfo[2], out float fuelUsing) ||
                !float.TryParse(vehicleInfo[3], out float fuelLevel)
            )
            {
                throw new ArgumentException("Wrong argument types");
            }

            switch (vehicleInfo[0]) 
            { 
                case "Car": 
                    vehicles.Add(new Car(maxFuelLevel, fuelLevel, fuelUsing));
                    break;
                case "Bus": 
                    vehicles.Add(new Bus(maxFuelLevel, fuelLevel, fuelUsing));
                    break;
                case "Truck": 
                    vehicles.Add(new Truck(maxFuelLevel, fuelLevel, fuelUsing));
                    break;
                default: throw new ArgumentException("Wrong vehicle params");
            }

            Console.WriteLine("Vehicle created");

        }

        void ActionVehicle(string[] actionInfo)
        {
            if(actionInfo[0] == "End")
            {
                isPlaying = false;
                Console.WriteLine("Game over");
            }
            else
            {
                if (
                !float.TryParse(actionInfo[2], out float actionSize)
            )
                {
                    throw new ArgumentException("Wrong argument types");
                }

                int vehicleIndex = vehicles.FindIndex(vehicle => vehicle.GetType().ToString().Split(".")[1] == actionInfo[1]);
                if (vehicleIndex < 0) throw new ArgumentException("Wrong vehicle");

                switch (actionInfo[0])
                {
                    case "Drive":
                        Console.WriteLine(vehicles[vehicleIndex].Drive(actionSize));
                        break;
                    case "Refuel":
                        Console.WriteLine(vehicles[vehicleIndex].FillUp(actionSize));
                        break;
                    default:
                        Console.WriteLine("Wrong action type");
                        break;
                }

            }

            
        }

        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine($"Vehicle №{i}");
            CreateNewVehicle(Console.ReadLine().Split(" "));
        }

        while (isPlaying)
        {
            ActionVehicle(Console.ReadLine().Split(" "));
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


