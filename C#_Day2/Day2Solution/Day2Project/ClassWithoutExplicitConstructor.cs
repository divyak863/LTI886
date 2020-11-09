using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Project
{
    class ClassWithoutExplicitConstructor
    {
        int Num;
       // the constructor that the compiler would provide
        //public ClassWithoutExplicitConstructor() { }
        public void PrintNumber()
        {
            Console.WriteLine("The number is "+Num);
        }
    }
}
