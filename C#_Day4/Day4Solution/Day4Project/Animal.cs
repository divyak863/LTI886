using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    class Animal
    {
        public virtual void Move()
        {
            Console.WriteLine("All animals move");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzz");
        }
        public void Eat()
        {
            Console.WriteLine("much munch");
        }
    }
}
