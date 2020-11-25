using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CodilityProject
{
    class MinValue
    {
        public int CurrValue;
        public int? NextValue;
        public MinValue() { }
        public MinValue(int cv,int? nv)
        {
            CurrValue = cv;
            NextValue = nv;
        }
    }
    class Program
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            int[] result = new int[P.Length];
            Dictionary<char, int> nucleotide = new Dictionary<char, int>()
            {
                { 'A',1 },
                { 'C',2 },
                { 'G',3 },
                { 'T',4 }
            };
            MinValue[] impact = new MinValue[S.Length];
            Stack<MinValue> stack = new Stack<MinValue>();
            for (int i = 0; i < S.Length; i++)
            {
                impact[i] = new MinValue(nucleotide[S[i]],null);
                while (stack.Count > 0 && impact[i].CurrValue < stack.Peek().CurrValue)
                    stack.Pop().NextValue = i;
                if (impact[i].CurrValue > 1)
                    stack.Push(impact[i]);
            }
            for (int i = 0; i < P.Length; i++)
            {
                MinValue minValue = impact[P[i]];
                if(minValue.CurrValue>1)
                {
                    while ((minValue.NextValue??Q[i]+1)<=Q[i])
                    {
                        minValue = impact[minValue.NextValue.Value];
                    }
                }
                result[i] = minValue.CurrValue;
            }
            return result;
        }
        public int MinAvgTwoSlice(int[] A)
        {
            int result = -1;
            int startPosition = 0, endPosition = 1, resultStart = 0;
            double sum = A[startPosition] + A[endPosition],avg = sum/2.0,temp1,temp2;
            for (int i = 1; i < A.Length; i++)
            {
                temp1 = (double)(sum += A[i])/(i-startPosition + 1);
                if (temp1 < avg)
                {
                    avg = temp1;
                    resultStart = startPosition;
                }
                temp2 = (double)(A[i - 1] + A[i] / 2.0);
                if (temp2 < avg)
                {
                    endPosition = i;
                    startPosition = endPosition - 1;
                    resultStart = startPosition;
                    avg = temp2;
                }
                else if (temp2 < temp1)
                {
                    startPosition = i - 1;
                    sum = A[startPosition] + A[i];
                }
                result = resultStart;
            }
            return result;
        }
        int Distinct(int[] A)
        {
            int count = A.Length > 0 ? 1 : 0;
            if (A.Length > 1)
            {
                Array.Sort(A);
                int current = A[0];
                for (var i = 0; ++i < A.Length;)
                    if (current != A[i])
                    {
                        ++count;
                        current = A[i];
                    }
            }
            return count;
        }
        int CalculateInter(int[] A)
        {
            long[] leftPoints = new long[A.Length];
            long[] rightPoints = new long[A.Length];
            long result = 0, interPoint = 0;
            for (int i = 0; i < A.Length; i++)
            {
                long leftIdx =0, rightIdx = 0;
                leftIdx = (long)Math.Max(0, (long)i - A[i]);
                leftPoints[leftIdx] += 1;
                rightIdx = (long)Math.Min(A.Length-1, (long)i + A[i]);
                rightPoints[rightIdx] += 1;
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (leftPoints[i] > 0)
                {
                    result += interPoint * leftPoints[i] + (leftPoints[i] * (leftPoints[i] - 1) / 2);
                    interPoint += leftPoints[i];
                }
                interPoint -= rightPoints[i];
            }
            if (result > 10000000)
                result = -1;
            return (int)result;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //TC', [0, 0, 1], [0, 1, 1]
            //string str1 = "TC";
            //int[] arr1 = { 0, 0, 1 };
            //int[] arr2 = { 0, 1, 1 };

            //int[] res = program.solution(str1, arr1, arr2);
            //foreach (int item in res)
            //{
            //    Console.Write(item+", ");
            //}
            //int[] arr1 = { 4, 2, 2,5,1,5,8 };
            //int result = program.MinAvgTwoSlice(arr1);
            //Console.WriteLine(result);
            // [1, 2147483647, 0]
            int[] arr1 = { 1, 2147483647, 0 };
            int result = program.CalculateInter(arr1);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
