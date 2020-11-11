using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day4Project
{
    class Child :Parent
    {
        public sealed override void M1()
        {
            base.M1();
        }
    }
    class GrandChild :Child
    {
        //public override void M1()
        //{
        //    base.M1();
        //}
    }
}
