using System;
using System.Linq;

namespace Arrays
{
    /*
     *  1.
     *  Найти сумму четных чисел в массиве
     *
     *  2.
     *  Найти наименьшее число в массиве
     *  
     *  1.
     *  Find the sum of even numbers in an array

     *  2.
     *  Find smallest number in an array
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 8. Arrays");

            Console.Write("Enter the size of the array: ");
            int dimension = int.Parse(Console.ReadLine());

            double[] MyArray = new double[dimension];            

            Console.WriteLine("Fill the array:");
            for (int i = 0; i < dimension; i++)
            {
                Console.Write("[" + (i + 1) + "]: ");
                MyArray[i] = int.Parse(Console.ReadLine());                
            }

            double sum = 0, smallestNumber = MyArray[0];

            for (int i = MyArray.Length - 1; i >= 0; i--)
            {
                Console.Write(MyArray[i] + "  ");

                if (MyArray[i] % 2 == 0)
                {
                    sum += MyArray[i];
                }                                                
            }

            for (int i = 1; i < MyArray.Length; i++)
            {
                if (smallestNumber > MyArray[i])
                {
                    smallestNumber = MyArray[i];
                }
            }
                        
            Console.WriteLine();
            Console.WriteLine("Least number: " + smallestNumber);            
            Console.WriteLine("Sum = " + sum);
        }
    }
}
