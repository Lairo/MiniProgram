using MiniProgram.Calc;
using System;

namespace MiniProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator(0, 0, ' ');
            while (true)
            {
                Console.Write("What type of calculation do you want to perform? (+, -, * or /): ");

                char sign = Console.ReadKey().KeyChar;
                if (sign == '-' || sign == '/' || sign == '+' || sign == '*')
                {
                    while (cal.FirstNumber == 0)
                    {
                        Console.Write("\nWrite the first number:\n");
                        string bob = Console.ReadLine();
                        if (int.TryParse(bob, out int x) && x != 0)
                        {
                            cal.FirstNumber = x;

                            while (cal.SecondNumber == 0)
                            {
                                Console.Write("\nWrite the second number:\n");
                                string steven = Console.ReadLine();
                                if (int.TryParse(steven, out int y) && y != 0)
                                {
                                    cal.SecondNumber = y;
                                    cal.Operation(sign);

                                    Console.WriteLine("\nWould you like to try again?\n");
                                    Console.Write("Write 'yes' to restart application: ");
                                    string answer = Console.ReadLine();

                                    if (answer.ToLower() != "yes")
                                    {
                                        Environment.Exit(0);
                                    }
                                    Console.Clear();

                                }
                                else
                                {
                                    Console.WriteLine("Try again! This time with actual number... -_-*");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Try again! This time with actual number... -_-*");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("\nChoose a valid operator type!");
                }


            }
        }
    }
}
