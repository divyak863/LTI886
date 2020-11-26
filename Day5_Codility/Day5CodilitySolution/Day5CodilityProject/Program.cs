using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5CodilityProject
{
    class Program
    {
        void M1()
        {
            
            M2();
            Console.WriteLine("M1");
        }

        private void M2()
        {
            M3();
            Console.WriteLine("M2");
        }

        private void M3()
        {
            Console.WriteLine("M3");
        }
        public int solution(int[] H)
        {
            int result = 1;
            Stack<int> blocks = new Stack<int>();
            blocks.Push(H[0]);
            for (int i = 0; i < H.Length; i++)
            {
                int height = H[i];
                while (blocks.Count>0 && blocks.Peek()>H[i])
                {
                    blocks.Pop();
                }
                if(blocks.Count==0 || blocks.Peek() != H[i])
                {
                    blocks.Push(H[i]);
                    result++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            new Program().M1();
            Console.ReadKey();
        }
    }
}
