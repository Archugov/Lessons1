using System;

namespace SumMultipleThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1, value2, value3;
            Console.WriteLine("Task 2. Sum and multiple of three numbers.\n");

            Console.Write("First number  - ");
            value1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second number - ");
            value2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Third number  - ");
            value3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sum of numbers:      " + Convert.ToString(value1 + value2 + value3));
            Console.WriteLine("Multiple of numbers: " + Convert.ToString(value1 * value2 * value3));
        }
    }
}
