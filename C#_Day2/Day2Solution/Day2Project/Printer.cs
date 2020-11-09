using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Project
{
    class Printer
    {
        public double Price { get; set; }
        public int NoOfCatr { get => noOfCatr; set => noOfCatr = value*10; }

        private int noOfCatr;
        
        public void PrintDetails()
        {
            Console.WriteLine("The value from variable "+noOfCatr);
        }
    }
}
