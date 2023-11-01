using System;

namespace Währungsrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zum Währungsrechner!");

            // Wechselkurs CHF zu EUR
            double chfToEurExchangeRate = 1.04;

            Console.Write("Bitte geben Sie den Betrag in CHF ein: ");
            double chfAmount = Convert.ToDouble(Console.ReadLine());

            // Währungsumrechnung
            double eurAmount = chfAmount * chfToEurExchangeRate;

            Console.WriteLine($"{chfAmount} CHF entsprechen {eurAmount} EUR.");

            Console.WriteLine("Vielen Dank für die Nutzung des Währungsrechners!");
        }
    }
}
