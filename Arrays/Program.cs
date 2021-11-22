using System;
using System.Linq;

namespace Arrays
{
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
                Console.Write("[" + i + "]: ");
                MyArray[i] = int.Parse(Console.ReadLine());                
            }

            double sum = 0, leastNumber = MyArray[0];

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
                if (leastNumber > MyArray[i])
                {
                    leastNumber = MyArray[i];
                }
            }
                        
            Console.WriteLine();
            Console.WriteLine("Least number: " + leastNumber);            
            Console.WriteLine("Sum = " + sum);
        }
    }
}
