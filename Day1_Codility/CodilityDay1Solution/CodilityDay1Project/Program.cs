using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodilityDay1Project
{
    class Program
    {

        bool CreditCardCheck(string number)
        {
            int N = 32;
            //string binaryNumbers = Convert.ToString(N, 2);
            ////Console.WriteLine(binaryNumbers);
            //int longGap = 0, currentGap = 0;
            //int idx = binaryNumbers.LastIndexOf('1');
            //if (idx < binaryNumbers.Length - 1)
            //    binaryNumbers = binaryNumbers.Substring(0, idx);
            //Console.WriteLine(binaryNumbers);

            //string binaryNumbers = Convert.ToString(N, 2);
            //Regex requiredPattern = new Regex("(?<=1)(0*)(?=1)");
            //var gap = requiredPattern.Matches(binaryNumbers)
            //            .Cast<Match>()
            //            .Select(str => str.Length)
            //            .Max();
            //Console.WriteLine(gap);

            int i = 6;
            int j = i ^ 6;
            j = j ^ 2;
            j = j ^ 5;
            j = j ^ 4;
            j = j ^ 2;
            j = j ^ 5;
            Console.WriteLine(j);
            //if (number.Length != 16)
            //    return false;
            //List<int> numbers = new List<int>();
            //for (int i = 0; i < 16; i++)
            //{
            //    numbers.Add(Convert.ToInt32(number[i].ToString()));
            //}
            //numbers.Reverse();
            //int sum = 0;
            //for (int i = 0; i < 16; i++)
            //{
            //    if(i%2 !=0)
            //    {
            //        numbers[i] *= 2;
            //        if (numbers[i] > 9)
            //            numbers[i] -= 9;
            //    }
            //    sum += numbers[i];
            //}
            //if (sum % 10 == 0)
            //    return true;
            return false;
        }
        void PrintRightAngleTriangle()
        {
            int size = 0;
            Console.WriteLine("Please enter the number of lines");
            while (!int.TryParse(Console.ReadLine(),out size))
            {
                Console.WriteLine("Invalid number");
            }
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            bool res = new Program().CreditCardCheck("4477468343113004");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
