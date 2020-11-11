using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    class A6 : Car
    {
        public override void DisplayBrand()
        {
            Console.WriteLine("Audi");
        }
    }
    class Series5 : Car
    {
        public override void DisplayBrand()
        {
            Console.WriteLine("BMW");
        }
    }
}
