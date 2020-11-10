using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Project
{
    class Dog:Animal
    {
        public Dog()
        {
            Console.WriteLine("Look its a dog....");
        }
        ~Dog()
        {
            Console.WriteLine("The dog ran away");
        }
        public void Bark()
        {
            Console.WriteLine("bow wow");
        }
    }
}
