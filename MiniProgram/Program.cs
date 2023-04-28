using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Bob", Age = 21, HasPet = true};

            person.Greeting();
        }
    }
}
