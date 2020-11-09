using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Project
{
    class Example
    {
        static int iNumStatic = 10;
        int iNumInstance = 10;
        Example()
        {
            iNumInstance++;
            iNumStatic++;
            Console.WriteLine("The constructor");
        }
        void PrintAll()
        {
            Console.WriteLine("Instance number value "+iNumInstance); 
            Console.WriteLine("Static number value " + iNumStatic);
        }
        ~Example()
        {
            Console.WriteLine("The Destructor");
        }
        void InstanceMethod()
        {
            //StaticMethod();
            Console.WriteLine("Instance method");
        }
        static void StaticMethod()
        {
            Example e1 = new Example();
            e1.InstanceMethod();
            Console.WriteLine("Static Method");
        }
        static void Main(string[] a)
        {
            //Console.WriteLine("From the Example Class");
            //Example e1 = new Example();
            //StaticMethod();
            ////e1 = null;//removing the reff to the object
            ////e1.InstanceMethod();
            //GC.Collect();
            Console.WriteLine("First Object");
            Example e1 = new Example();
            e1.PrintAll();
            Console.WriteLine("Second Object");
            Example e2 = new Example();
            e1.PrintAll();
            Console.ReadKey();
        }
    }
}
