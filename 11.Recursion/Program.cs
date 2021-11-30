using System;

namespace _11.Recursion
{
    /*
     * 1.
     * Вывод массива с помощью рекурсии
     * 
     * 2.
     * Найти сумму элементов массива с помощью рекурсии
     * 
     * 3.
     * Найти сумму цифр числа
     * 
     */
    class Program
    {
        static void PrintArray<T>(T[] Array, int index = 0)
        {
            if (index < Array.Length)
            {
                Console.WriteLine(Array[index]);
                PrintArray(Array, index + 1);
            }
        }

        static void SumArray(int[] array, int sum = 0, int i = 0)
        {
            if (i >= array.Length)
            {
                Console.WriteLine("Sum = " + sum);
                return;
            }

            sum += array[i];
            SumArray(array, sum, i + 1);
        }

        static void Main(string[] args)
        {
            string[] myArray = { "Pasha", "Sasha", "Masha", "Dasha" };

            int[] intArray = { 5, 1, 8, 9, 0, 5 };

            PrintArray(myArray);
            SumArray(intArray);
        }
    }
}
