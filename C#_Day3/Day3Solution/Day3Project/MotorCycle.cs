using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Project
{
    class MotorCycle : Cycle
    {
        public MotorCycle()
        {
            Speed = 60;
        }
        public void ChangeGear()
        {
            Console.WriteLine("CHange gear t o change speed");
        }
    }
}
