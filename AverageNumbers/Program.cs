using System;

namespace AverageNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1. Average of two numbers.\n");

            Console.Write("First number  - ");
            double value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second number - ");
            value += Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Average = " + value / 2);
        }
    }
}
