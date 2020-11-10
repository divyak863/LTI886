using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Project
{
    class RaceingMotorCycle:MotorCycle
    {
        public RaceingMotorCycle()
        {
           Speed = 100;
        }
        public void RaiseAndRace()
        {
            Console.WriteLine("Race is my thing");
        }
    }
}
