using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num1_1409
{
    class Tools
    {
        public static List<int> IntLine()
        {
            List<int> Integers = new List<int>();
            string num = "", Line = Console.ReadLine();
            for (int i = 0; i < Line.Length; i++)
            {
                if ((Line[i].CompareTo(' ') != 0) && (i != Line.Length - 1)) num += Line[i];
                else
                {
                    if (i == Line.Length - 1) num += Line[i];
                    Integers.Add(Convert.ToInt32(num));
                    num = "";
                }
            }
            return Integers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums = Tools.IntLine();
            int sum = nums[0] + nums[1] - 1;
            Console.WriteLine((sum - nums[0]) + " " + (sum - nums[1]));
        }
    }
}
