using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    class Showroom
    {
        void DisplayCar(Car car)
        {
            car.Run();
            car.DisplayBrand();
        }
        static void Main(string[] str)
        {
            Showroom showroom = new Showroom();
            Car car = new Series5();
            showroom.DisplayCar(car);
            Console.ReadKey();
        }
    }
}
