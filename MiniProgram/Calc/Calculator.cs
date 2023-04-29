using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProgram.Calc
{
    internal class Calculator
    {

        //public static string Sign(string x)
        //{
        //    if (x == '+')
        //    {
        //        return Add();
        //    }
        //    return;
        //}

        public static int Add(int x, int y)
        {
            int Num1 = x;
            int Num2 = y;
            int Answer = Num1 + Num2;
            return Answer;
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
    }
}
