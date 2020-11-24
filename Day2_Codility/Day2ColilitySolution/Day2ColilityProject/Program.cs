using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ColilityProject
{
    class Program
    {
        public int solution(int[] A)
        {
            double sum = A.Sum(e => (double)e);
            int num1 = A[0];
            A.
            int num2 = (int)sum - A[0];
            int result = Math.Abs(num1 - num2);
            for (int i = 1; i < A.Length-1; i++)
            {
                num1 += A[i];
                num2 -= A[i];
                int diff = Math.Abs(num1 - num2);
                if (result > diff)
                    result = diff;
            }
            return 0;
        }

        int[] Counting(int[] A, int m)
        {
            int[] result = new int[m+1];
            for (int i = 0; i < A.Length; i++)
            {
                result[A[i]] += 1;
            }
            return result;

        }
        bool CheckSwap(int[] A, int[] B, int m)
        {
            int length = A.Length;
            double sum_A = A.Sum();
            double sum_B = B.Sum();
            double d = sum_A - sum_B;
            if(d%2 ==1)
                return false;
            d = Math.Floor(d /2);
            int[] count = Counting(A, m);
            for (int i = 0; i < length; i++)
            {
                if ((0 <= B[i] - d) && (B[i] - d < m) && (count[B[i] - (int)d] > 0))
                    return true;
            }
            return false;
        }

        int FrogJump(int[] A, int X)
        {
            int res = A.ToList().IndexOf(X);
            int result = -1;
            int[] temp = new int[X];
            int no_of_leaves = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if(temp[A[i]-1]==0)
                {
                    temp[A[i] - 1] += 1;
                    no_of_leaves++;
                    if(no_of_leaves==X)
                    {
                        result = i;
                        break;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1,4,2,7 };
            int[] arr2 = { 3, 6, 2, 1 };
            //int[] res = new Program().Counting(arr,5);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            int[] A = { 1, 3,1,4,2,3,5,4 };
            Console.WriteLine(new Program().FrogJump(A, 5));
            Console.ReadKey();
        }
    }
}
