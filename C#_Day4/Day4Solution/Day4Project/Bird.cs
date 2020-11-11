using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    class Bird : IFlying,ILiving
    {
        public void Fly()
        {
            Console.WriteLine("Keep flapping the wings and Glide");
        }

        public void Land()
        {
            Console.WriteLine("Stop flapping the wings");
        }

        public void TakeOff()
        {
            Console.WriteLine("Flap the wings hard and fast");
        }

        public void Chirp()
        {
            Console.WriteLine("Chirp chirp");
        }

        public void Eat()
        {
            Console.WriteLine("Eats fruits");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeps in nest");
        }
    }
}
