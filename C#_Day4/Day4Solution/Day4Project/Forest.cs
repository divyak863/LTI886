using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    class Forest
    {
        void TreeLife(IFlying flying)
        {
            flying.TakeOff();
            flying.Fly();
            flying.Land();
        }
        void Live(ILiving life)
        {
            life.Eat();
            life.Sleep();
        }
        static void Main(string[] a)
        {
            //Bird bird = new Bird();
            //Forest forest = new Forest();
            //forest.TreeLife(bird);
            //forest.Live(bird);
            string s = null;//ref
            //int i1 = Convert.ToInt32(s);//value- Unboxing
            int i2 = int.Parse(s);
            Console.WriteLine(i2.ToString());//boxing
            Console.ReadKey();
        }
    }
}
