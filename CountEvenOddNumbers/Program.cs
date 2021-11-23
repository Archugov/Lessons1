using System;

namespace CountEvenOddNumbers
{
    /*
     *  1.
     *  Подсчитать сумму и количество четных и нечетных чисел в заданном диапазоне
     *  
     *  1.
     *  Count sum/quantity of even and odd numbers in a given range
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 6. Count the number of even and odd numbers in a given range.");

            Console.WriteLine("Input range");

            Console.Write("From: ");
            int rangeFrom = int.Parse(Console.ReadLine());

            Console.Write("To:   ");
            int rangeTo = int.Parse(Console.ReadLine());

            uint countEven = 0, countOdd = 0;
            int sumEven = 0, sumOdd = 0;
            while (rangeFrom <= rangeTo)
            {
                if (rangeFrom % 2 == 0)
                {
                    countEven++;
                    sumEven += rangeFrom;
                }
                else
                {
                    countOdd++;
                    sumOdd += rangeFrom;
                }

                rangeFrom++;
            }

            Console.WriteLine("Count even numbers: " + countEven);
            Console.WriteLine("Sum even numbers:   " + sumEven);
            Console.WriteLine("Count odd numbers:  " + countOdd);
            Console.WriteLine("Sum odd numbers:    " + sumOdd);
        }
    }
}
