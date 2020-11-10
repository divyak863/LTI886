using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Project
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("This is an animal");
        }
        ~Animal()
        {
            Console.WriteLine("Going going gone...");
        }
        public void Move()
        {
            Console.WriteLine("Moves from one place to another");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzzzzz");
        }
    }
}
