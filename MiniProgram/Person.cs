using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProgram
{
    internal class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine($"Hello my name is {Name}, I am {Age} years old, and I have a pet");
        }

        public void Sleep()
        {

        }

        public void GetPet()
        {

        }


    }
}
