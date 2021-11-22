using System;

namespace ParityCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4. Parity check.");

            Console.Write("Input number: ");

            if (int.Parse(Console.ReadLine()) % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else Console.WriteLine("Odd number");
        }
    }
}
