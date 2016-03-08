using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num2_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> nums = new List<int>();
            while (n != 0)
            {
                nums.Add(0);
                nums.Add(1);
                for (int i = 1; i <= n/2; i++)
                {
                    nums.Add(nums[i]);
                    if (i != n/2 || n == n/2 * 2 + 1) nums.Add(nums[i] + nums[i + 1]);
                }
                Console.WriteLine(nums.Max());
                nums.Clear();
                n = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
