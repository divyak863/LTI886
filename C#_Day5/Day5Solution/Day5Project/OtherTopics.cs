using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Project
{
    class OtherTopics
    {
        enum Priority
        {
            VeryHigh,
            High,
            Medium,
            Low,
            VeryLow
        }

        void UnderstandingEnum() 
        {
            Priority priority = Priority.VeryHigh;
            Console.WriteLine(priority);
            int val = (int)priority;
            Console.WriteLine(val);
            if(priority == Priority.VeryHigh)
                Console.WriteLine("Start now");
            else
                Console.WriteLine("Start");
        }

        void UnderstandingNulls()
        {
            int? num = 10;
            int? num2 = (num??0) * 10;
            Console.WriteLine(num2);
        }
        static void Main(string[] a)
        {
            new OtherTopics().UnderstandingEnum();
            Console.ReadKey();
        }
    }
}
