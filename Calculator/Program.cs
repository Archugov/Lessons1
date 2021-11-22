using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                Console.Clear();
                Console.WriteLine("Task 5. Calculator.");

                try
                {
                    Console.Write("Input first value: ");
                    double firstValue = double.Parse(Console.ReadLine());

                    Console.Write("Input second value: ");
                    double secondValue = double.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Select an action: " +
                                            "\n 1: '+', " +
                                            "\n 2: '-', " +
                                            "\n 3: '*', " +
                                            "\n 4: '/'");

                Console.Write("Your choice: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine(Convert.ToString(firstValue) + " + " + Convert.ToString(secondValue) + " = " + Convert.ToString(firstValue + secondValue));
                        break;
                    case 2:
                        Console.WriteLine(Convert.ToString(firstValue) + " - " + Convert.ToString(secondValue) + " = " + Convert.ToString(firstValue - secondValue));
                        break;
                    case 3:
                        Console.WriteLine(Convert.ToString(firstValue) + " * " + Convert.ToString(secondValue) + " = " + Convert.ToString(firstValue * secondValue));
                        break;
                    case 4:
                        Console.WriteLine(Convert.ToString(firstValue) + " / " + Convert.ToString(secondValue) + " = " + Convert.ToString(firstValue / secondValue));
                        break;
                    default:
                        Console.Write("Invalid input!");
                        break;
                }
            }
        }
    }
}
