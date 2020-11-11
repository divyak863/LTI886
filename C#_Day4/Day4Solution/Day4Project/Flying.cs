using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    interface IFlying
    {
        void TakeOff();
        void Fly();
        void Land();
    }
    interface ILiving
    {
        void Eat();
        void Sleep();
    }
}
