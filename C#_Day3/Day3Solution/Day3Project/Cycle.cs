using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Project
{
    class Cycle
    {
        public int Speed { get; set; }
        public Cycle()
        {
            Speed = 10;
        }

        public void Go()
        {
            Console.WriteLine("Helps us to move in speed "+Speed);
        }
    }
}
