using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Project
{
    class Road
    {
        void AddVehicle()
        {
            Cycle bsa = new Cycle();
            bsa.Go();
            MotorCycle re = new MotorCycle();
            re.Go();
            RaceingMotorCycle bmw = new RaceingMotorCycle();
            bmw.RaiseAndRace();
            bmw.ChangeGear();
            bmw.Go();
        }
        static void Main(string[] a)
        {
            Road nh45 = new Road();
            nh45.AddVehicle();
            Console.ReadKey();
        }
    }
}
