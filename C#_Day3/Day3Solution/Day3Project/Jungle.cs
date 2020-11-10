using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Project
{
    class Jungle
    {

        static void Main(string[] str)
        {
            //Tiger tiger = new Tiger();
            //tiger.Move();
            //tiger.Roar();
            //tiger.Sleep();
            //Console.WriteLine("----------------------");
            //Dog dog = new Dog();
            //dog.Move();
            //dog.Bark();
            //dog.Sleep();
            //Animal a = new Dog();//allowed
            //a.Sleep();
            //Tiger t = new Animal();//not allowed
            Animal dog = new Dog();
            dog = null;
            GC.Collect();
            Console.ReadKey();

        }
    }
}
