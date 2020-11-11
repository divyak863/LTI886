using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    class Cart
    {
        void PullCart(Animal animal)
        {
            animal.Eat();
            animal.Move();
            animal.Sleep();
        }
        static void Main(string[] a)
        {
            Animal animal = new Animal();
            Console.WriteLine("Select an animal for the cart. Horse/Donkey");
            string choice = Console.ReadLine().ToUpper();
            switch (choice)
            {
                case "HORSE":
                    animal = new Horse();
                    break;
                case "DONKEY":
                    animal = new Donkey();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Cart cart = new Cart();
            cart.PullCart(animal);
            CannotInheritFrom obj = new CannotInheritFrom();
            obj.Age = 19;
            Console.ReadKey();
        }

    }
}
