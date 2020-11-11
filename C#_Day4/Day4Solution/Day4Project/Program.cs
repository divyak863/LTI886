using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    class Program
    {
        void Add(int num1,int num2)
        {
            Console.WriteLine("The sum is "+(num1+num2));
        }
        void Add(int num1, int num2,int num3)
        {
            Console.WriteLine("The sum of 3 is " + (num1 + num2+num3));
        }
        void Add(int num1, int num2, float num3)
        {
            Console.WriteLine("The sum of 3 with a float involved  is " + (num1 + num2 + num3));
        }
        void Add(int num1, float num3, int num2)
        {
            Console.WriteLine("The sum of 3 with a float involved inbetween  is " + (num1 + num2 + num3));
        }
        void Add(string num1, string num2)
        {
            Console.WriteLine("The result is " + (num1 + num2));
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.Add(10, 10,12.3f);
            //Movie movie1 = new Movie(10,"Ice age");
            //Movie movie2 = new Movie(20, "Rio");
            //Movie movie3 = movie1 + movie2;
            //movie1.PrintMovie();
            //movie2.PrintMovie();
            //Console.WriteLine("-------------------------");
            //movie3.PrintMovie();
            //string s1 = "Hello";
            //string s2 = "World";
            //string s3 = s1 + s2;
            //Console.WriteLine(s3);
            Movie movie = new Movie(20, "Rio");
            movie[0] = "ABC";
            movie[1] = "XYZ";
            movie[2] = "AAC";
            movie.PrintMovie();
            Console.WriteLine("Print the cast is position 1 "+movie[1]);
            //int findIdx = movie["XYZ"];
            Console.WriteLine("The cast is at position "+ movie["XYZ"]);
            Console.ReadKey();
        }
    }
}
