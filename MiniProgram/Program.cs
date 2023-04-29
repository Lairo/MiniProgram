using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProgram.People;
using MiniProgram.Calc;

namespace MiniProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What type of calculation do you want to perform? (+, -, * or /): ");

            string sign = Console.ReadLine();

            Console.Write("x:");
            string bob = Console.ReadLine();
            int.TryParse(bob, out int x);
            Console.Write("y:");
            string steven = Console.ReadLine();
            int.TryParse(steven, out int y);


            switch (sign) {
                case "+":
                    Console.WriteLine($"The Answer: {Calculator.Add(x, y)}.");
                    break;
                case "-":
                    Console.WriteLine($"The Answer: {Calculator.Subtract(x, y)}.");
                    break;
                case "*":
                    Console.WriteLine($"The Answer: {Calculator.Multiply(x, y)}.");
                    break;
                case "/":
                    Console.WriteLine($"The Answer: {Calculator.Divide(x, y)}.");
                    break;
            }

            //Console.WriteLine($"Answer: {}");

        }
    }
}
