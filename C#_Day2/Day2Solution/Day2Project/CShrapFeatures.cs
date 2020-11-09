using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Project
{
    class CShrapFeatures
    {
        void UnderstandingDatatypes()
        {
            int num1 = 10;//value
            Mobile m = new Mobile();//reff
            float f1 = 123.3f;
            f1 = num1;//allowed coz no loss of data
            //num1 = f1;//error
            num1 = (int)f1;//Explicit conversion is required
            double d1 = 1000;
            d1 = f1;//allowed
            //f1 = d1;//not allowed
            f1 = (float)d1;
            checked
            {
                num1 = int.MaxValue;
                num1++;
                Console.WriteLine(num1);
            }
        }
        void UndertsnadingArray()
        {
            Console.WriteLine("Please enter the arra's size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            arr[0] = 100;
            arr[1] = 122;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 10 + 10;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        void UnderstandingMultidimArray()
        {
            double[,] twoDimArray = new double[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    twoDimArray[i, j] = (i + j) * i * j+i+j;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(twoDimArray[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        void UnderstandingJaggedArray()
        {
            float[][] arr = new float[4][];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please enter the columns for row "+(i+1));
                int size = int.Parse(Console.ReadLine());
                arr[i] = new float[size];
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = i / (j + 1) * i + j;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
        void UnderstandingObjectArray()
        {
            User[] users = new User[3];
            for (int i = 0; i < 3; i++)
            {
                users[i] = new User();
                Console.WriteLine("Please enter the data for user "+(i+1));
                users[i].TakeUserData();
            }
            Console.WriteLine("Here comes data of all users");
            for (int i = 0; i < 3; i++)
            {
                users[i].PrintUserData();
            }
        }
        static void Main(string[] a)
        {
            CShrapFeatures csf = new CShrapFeatures();
            //csf.UnderstandingDatatypes();
            csf.UnderstandingObjectArray();
            Console.ReadKey();
        }
    }
}
