using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Pascal_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            char DescrKey = ' ', TaskKey = ' ';
            while (DescrKey != 'N')
            {
                Console.WriteLine(Description.Info.descr);
                int key = Convert.ToInt32(Console.ReadLine());
                while (TaskKey != 'N')
                {
                    //if (TaskKey != ' ') Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("#" + key);
                    MethodInfo Method = Type.GetType("Code.Pascal").GetMethod("Num" + key.ToString());
                    Method.Invoke(null, null);
                    Console.WriteLine("\nХотите ввести новый набор данных?(Y/N): ");
                    TaskKey = Convert.ToChar(Console.Read());
                    Console.ReadLine();
                }
                TaskKey = ' ';
                Console.WriteLine("\nХотите выбрать другую задачу?(Y/N): ");
                DescrKey = Convert.ToChar(Console.Read());
                Console.ReadLine();
            }
        }
    }
}
