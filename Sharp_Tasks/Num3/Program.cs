using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Collections.Generic;

namespace Num3
{
    public class Read
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
            int k = Convert.ToInt32(Console.ReadLine());
            List<int> groups = new List<int>();
            groups = Read.IntLine();
            groups.Sort();
            int people = 0;
            for (int i = 0; i < k / 2 + 1; i++) people += groups[i] / 2 + 1;
            Console.Clear();
            Console.WriteLine(people);
            Console.ReadKey();
        }
    }
}
