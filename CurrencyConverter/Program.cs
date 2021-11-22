using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3. Currency converter.\n");

            double BYN, DOLLAR = 0.38, EURO = 0.32, RUB = 28.55;

            Console.WriteLine("Current exchange rate:");
            Console.WriteLine("DOLLAR: " + Convert.ToString(DOLLAR));
            Console.WriteLine("EURO:   " + Convert.ToString(EURO));
            Console.WriteLine("RUB:    " + Convert.ToString(RUB));

            Console.Write("Input BYN: ");
            BYN = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("BYN TO DOLLAR: " + Convert.ToString(DOLLAR * BYN));
            Console.WriteLine("BYN TO EURO:   " + Convert.ToString(EURO * BYN));
            Console.WriteLine("BYN TO RUB:    " + Convert.ToString(RUB * BYN));
        }
    }
}
