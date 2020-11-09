using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Project
{
    class Laptop
    {
        public float speed;
        public string display;
        public Laptop()
        {
            speed = 11.2f;
            display = "LED";
        }
        public void SwitchOn()
        {
            Console.WriteLine("The laptop is powered on");
        }
        public void PowerOff()
        {
            Console.WriteLine("Power gone.....");
        }
    }
}
