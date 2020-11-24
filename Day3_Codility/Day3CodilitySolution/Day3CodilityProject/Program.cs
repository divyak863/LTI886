using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3CodilityProject
{
    class Program
    {
        enum MyEnum
        {

        }
        //public int[] Solution(int N, int[] A)
        //{
        //    int[] result = new int[N];
        //    int max = 0, tempMax = 0;
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (A[i] - 1 == N)
        //            max = tempMax;
        //        else
        //        {
        //            result[A[i] - 1] = Math.Max(result[A[i] - 1], max);
        //            result[A[i] - 1]++;
        //            if (tempMax < result[A[i] - 1])
        //                tempMax = result[A[i] - 1];
        //        }
        //    }
        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        result[A[i] - 1] = Math.Max(result[i], max);
        //    }
        //    return result;

        //}
        //public int MissingNumber(int[] A)
        //{
        //    int result = 0;
        //    bool res = A.Where(n => n > 0).Distinct().OrderBy(n => n).Any(n => n != (result = result + 1)); 
        //    result = res? result : ++result;
        //    return result;
        //}
        //int[] Prefix_Sum(int[] A)
        //{
        //    int[] sum_array = new int[A.Length + 1];
        //    for (int i = 1; i < sum_array.Length; i++)
        //    {
        //        sum_array[i] = sum_array[i - 1] + A[i-1];
        //    }
        //    return sum_array;
        //}
        //int Count_Total(int[] A,int start,int end)
        //{
        //    return A[end + 1] - A[start];
        //}
        ////for p in xrange(min(m, k) + 1) :
        ////6 left_pos = k - p
        ////7 right_pos = min(n - 1, max(k, k + m - 2 * p))
        ////8 result = max(result, count_total(pref, left_pos, right_pos))
        ////9 for p in xrange(min(m + 1, n - k)):
        ////10 right_pos = k + p
        ////11 left_pos = max(0, min(k, k - (m - 2 * p)))
        ////12 result = max(result, count_total(pref, left_pos, right_pos))
        ////13 return result
        //int Count_Mushrooms(int[] A,int k,int m)
        //{
        //    int length = A.Length;
        //    int result = 0;
        //    int[] sum_array = Prefix_Sum(A);
        //    int left_pos = 0, right_pos = 0;
        //    for (int i = 0; i < Math.Min(k,m)+1; i++)
        //    {
        //        left_pos = k - i;
        //        right_pos = Math.Min(length - 1, Math.Max(k, k - m * i));
        //        result = Math.Max(result, Count_Total(sum_array, left_pos, right_pos));
        //    }
        //    for (int i = 0; i < Math.Min(m+1,length-k); i++)
        //    {
        //        right_pos = k + i;
        //        left_pos = Math.Max(0, Math.Min(k, k - (m - 2 * i)));
        //        result = Math.Max(result, Count_Total(sum_array, left_pos, right_pos));
        //    }
        //    return result;
        //}
        static void Main(string[] args)
        {
            Program program = new Program();
            //int[] arr = { 3, 4, 4, 6, 1, 4, 4 };
            //int[] res = program.Solution(5,arr);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] mush = { 2, 3, 7, 5, 1, 3, 9 };
            //int total = program.Count_Mushrooms(mush, 4, 6);
            //Console.WriteLine(total);
            Console.ReadKey();

        }
    }
}
