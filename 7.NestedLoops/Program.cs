using System;

namespace _7.NestedLoops
{
    /*
     *  1.
     *  Нарисовать треугольники в консоли без использования конструкции if/else

     *  1.
     *  Draw triangles in console without using if / else construct
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height of the triangle: ");
            int height = int.Parse(Console.ReadLine());

            //Console.Write("Enter the width of the triangle:  ");
            //int width = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = height; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}
