using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons1
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

            //---------------------------------------------------------------------------------
            
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

            //----------------------------------------------------------------------------------

            Console.WriteLine("Task 3. Currency converter.\n");

            double BYN, DOLLAR = 0.38, EURO = 0.32, RUB = 28.55;

            Console.WriteLine("Current exchange rate:");
            Console.WriteLine("DOLLAR: " + Convert.ToString(DOLLAR));
            Console.WriteLine("EURO:   " + Convert.ToString(EURO));
            Console.WriteLine("RUB:    " + Convert.ToString(RUB));

            Console.Write("Enter the amount in BYN: ");
            BYN = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("BYN TO DOLLAR: " + Convert.ToString(DOLLAR * BYN));
            Console.WriteLine("BYN TO EURO:   " + Convert.ToString(EURO *   BYN));
            Console.WriteLine("BYN TO RUB:    " + Convert.ToString(RUB *    BYN));

            Console.ReadKey();
        }
    }
}
