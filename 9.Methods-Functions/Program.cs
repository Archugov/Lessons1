using System;

namespace _9.Methods_Functions
{
    /*
     *  1.
     *  Написать метод который выводит на экран строку.
     *  Символы из которых состоит строка и их количество вводятся пользователем
     *
     *  2.
     *  Написать метод для поиска индекса элемента массива (int)
     *  Вернуть индекс первого найденного элемента
     *  
     *  1.
     *  Write a method that prints a string to the screen.
     *  The characters that make up the string and their number are entered by the user
     *  
     *  2.
     *  Write a method to find the index of an array element (int)
     *  Return the index of the first element found
     */

    class Program
    {

        static void PrintStr(string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
        }

        static int Index_Of_number(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i + 1;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 9.Methods & Functions.");

            Console.WriteLine("Task 9.1");

            Console.Write("Set the symbol: ");
            string symbol = Console.ReadLine();

            Console.Write("Set the number of characters: ");
            uint count = uint.Parse(Console.ReadLine());

            PrintStr(symbol, count);

            Console.WriteLine("Task 9.2");
            Console.Write("Size of array: ");
            int[] array = new int[int.Parse(Console.ReadLine())];

            Console.WriteLine("Fill the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[" + (i + 1) + "]: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Set the number: ");
            int number = int.Parse(Console.ReadLine());
            int index = Index_Of_number(array, number);

            if (index >= 0)
            {
                Console.WriteLine("Index - " + index);
            }
            else
            {
                Console.WriteLine("There is no such number in the array");
            }
        }
    }
}
