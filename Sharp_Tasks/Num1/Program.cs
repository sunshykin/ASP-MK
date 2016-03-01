using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num1
{
    class Stack
    { 
        static void SwapInt(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static int CheckSum(ref List<int> CheckList)
        {
            int heap1 = 0, heap2 = 0;
            for (int i = CheckList.Count - 1; i >= 0; i--)
            {
                if (heap1 > heap2) SwapInt(ref heap1, ref heap2);
                heap1 += CheckList[i];
            }
            return Math.Abs(heap1 - heap2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int sum, n = Convert.ToInt32(Console.ReadLine());
            List<int> stones = new List<int>();
            stones = Num3.Read.IntLine();
            stones.Sort();
            if (stones.Sum() % 2 == 0) sum = stones.Sum() / 2;
            else sum = stones.Sum() / 2 + 1;
            Console.WriteLine(Stack.CheckSum(ref stones));
        }
    }
}
