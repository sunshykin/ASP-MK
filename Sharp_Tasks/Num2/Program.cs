using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num2
{
    class Binary
    {
        public static int Num(int count)
        {
            int i = 1, sum = 1;
            while (sum < count)
            {
                sum += i;
                i++;
            }
            if (sum == count) return 1;
            else return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] k = new int[n];
            for (int i = 0; i < n; i++) k[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) Console.Write(Binary.Num(k[i])+ " ");
        }
    }
}
