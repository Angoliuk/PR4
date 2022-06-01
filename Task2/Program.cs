using System.Globalization;
using System.Text;
using Task2;

class Program
{
    public static void Main()
    {
        PrintTimeStamp();
        Console.WriteLine("---------------");
        ATMTransaction transactionBlocked = new ATMTransaction(123, new DateTime(2015, 12, 25), "Debit");
        ATMTransaction transactionOpened = new ATMTransaction(1234, new DateTime(2012, 12, 25), "Credit");

        transactionBlocked.modifies(false);
        transactionOpened.modifies(true);
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


