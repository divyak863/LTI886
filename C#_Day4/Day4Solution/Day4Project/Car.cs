using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    abstract class Car
    {
        public int Power { get; set; }

        public void Run()
        {
            Console.WriteLine("Runs quite fast");
        }

        public abstract void DisplayBrand();
        
    }
}
