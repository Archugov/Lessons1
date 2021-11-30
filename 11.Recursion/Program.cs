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

        static int SumArray(int[] array, int i = 0)
        {
            if (i >= array.Length)
                return 0;

            return array[i] + SumArray(array, i + 1);
        }

        static int SumNumbers(int value)
        {
            if (value < 10)
                return value;

            return value % 10 + SumNumbers(value / 10);
        }

        static void Main(string[] args)
        {
            string[] myArray = { "Pasha", "Sasha", "Masha", "Dasha" };

            int[] intArray = { 5, 1, 8, 9, 0, 5 };

            int value = 666;

            //PrintArray(myArray);
            //Console.WriteLine("sum = " + SumArray(intArray));
            Console.WriteLine(SumNumbers(value));
        }
    }
}
