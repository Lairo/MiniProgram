using System;

namespace MiniProgram.Calc
{
    internal class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public char Sign { get; set; }


        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public void Operation(char sign)
        {
            switch (sign)
            {
                case '+':
                    Console.WriteLine($"The Answer: {Add(FirstNumber, SecondNumber)}.");
                    break;
                case '-':
                    Console.WriteLine($"The Answer: {Subtract(FirstNumber, SecondNumber)}.");
                    break;
                case '*':
                    Console.WriteLine($"The Answer: {Multiply(FirstNumber, SecondNumber)}.");
                    break;
                case '/':
                    Console.WriteLine($"The Answer: {Divide(FirstNumber, SecondNumber)}.");
                    break;
            }
        }

        public Calculator(int x, int y, char sign)
        {
            this.FirstNumber = x;
            this.SecondNumber = y;
            this.Sign = sign;
        }
    }
}
