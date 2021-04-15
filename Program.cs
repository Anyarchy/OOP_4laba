using System;

namespace OOP_4laba
{
    class Program
    {
        static void Main(string[] args)
        {

            string randomString = "tokio drift vrooom vrooom vrmoomovm";
            char[] array = randomString.ToCharArray();
            Strings CS1 = new Strings();
            Strings CS2 = new Strings(array);
            Strings CS3 = new Strings(CS2);
            Console.WriteLine("\nStrings before changes:");
            CS1.PrinterText();
            CS2.PrinterText();
            CS3.PrinterText();
            CS1 = CS2 + CS3;
            CS3 = CS3 - 'o';
            Console.WriteLine("\nStrings after changes:");
            CS1.PrinterText();
            CS2.PrinterText();
            CS3.PrinterText();

        }
    }
}
