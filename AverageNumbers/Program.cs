using System;

namespace AverageNumbers
{
    /*
     *  1.
     *  Вычислить среднее арифметическое двух чисел
     *  
     *  1.
     *  Calculate the arithmetic mean of two numbers
     */
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
