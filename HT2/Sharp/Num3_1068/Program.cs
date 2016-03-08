using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num3_1068
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()), i = 1, sum = i;
            while (i != n)
            {
                if (i < n) i++;
                else i--;
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
