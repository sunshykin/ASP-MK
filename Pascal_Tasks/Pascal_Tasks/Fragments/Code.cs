using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Numerics.BigInteger;

namespace Code
{
    public class Tools
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
        public static bool Prime(int num)
        {
            if (num == 1) return false;
            for (int i = 2; i <= num / 2; i++) if (num % i == 0) return false;
            return true;
        }
        public static int GCD(int a, int b)
        {
            int c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
        public static int Mod(int num, int degree)
        {
            int res = 1;
            for (int i = 1; i <= degree; i++) res *= num;
            return res;
        }
        public static int Fact(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++) result *= i;
            return result;
        }
        public static int Reverse(int num)
        {
            string result = null;
            for (int i = num.ToString().Length - 1; i >= 0; i--) result += num.ToString()[i];
            return Convert.ToInt32(result);
        }
        public static int DecTo(int num, int radix)
        {
            int result = 0;
            while (num >= radix)
            {
                result = result * 10 + num % radix;
                num /= radix;
            }
            result = result * 10 + num;
            return Reverse(result);
        }
    }
    class Pascal
    {
        public static void Num1()
        {
            Console.WriteLine(@"Формулировка: Вывести на экран сообщение «Hello World!».
");
            Console.WriteLine("Hello World!");
        }
        public static void Num2()
        {
            Console.WriteLine("Формулировка: Вывести на экран три введенных с клавиатуры числа в порядке, обратном их вводу.\n");
            Console.WriteLine("Введите три числа, используя пробел для разделения:");
            List <int> numbers = new List<int>();
            numbers = Tools.IntLine();
            for (int i = numbers.Count() - 1; i >= 0; i--) Console.Write(numbers[i] + " ");
        }
        public static void Num3()
        {
            Console.WriteLine("Формулировка: Дано натуральное число меньше 256. Сформировать число, представляющее собой его квадрат.\n");
            Console.WriteLine("Введите число(меньше 256):");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num * num);
        }
        public static void Num4()
        {
            Console.WriteLine(@"Формулировка: Сформировать число, представляющее собой реверсную (обратную в порядке следования 
разрядов) запись заданного трехзначного числа. Например, для числа 341 таким будет 143.
");
            Console.WriteLine("Введите трехзначное число:");
            string num0 = Console.ReadLine(), num1 = null;
            for (int i = num0.Length - 1; i >= 0; i--) num1 += num0[i];
            Console.WriteLine(num1);
        }
        public static void Num5()
        {
            Console.WriteLine(@"Формулировка: Дано натуральное число меньше 16. Посчитать количество его единичных битов. Например,
если дано число 9, запись которого в двоичной системе счисления равна 1001_2 (цифра 2 справа от 
числа означает, что оно записано в двоичной системе счисления), то количество его единичных битов равно 2.
");
            Console.WriteLine("Введите число(меньше 16):");
            int n = Convert.ToInt32(Console.ReadLine()), count = 0;
            while (n > 0)
            {
                count += n % 2;
                n /= 2;
            }
            Console.WriteLine(count);
        }
        public static void Num6()
        {
            Console.WriteLine("Формулировка: Даны два числа. Вывести на экран то из них, которое больше.\n");
            Console.WriteLine("Введите числа, используя Enter для разделения:");
            int num1 = Convert.ToInt32(Console.ReadLine()), num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2) Console.WriteLine(num1);
            else Console.WriteLine(num2);
        }
        public static void Num7()
        {
            Console.WriteLine("Формулировка: Даны три числа. Вывести на экран то из них, которое больше.\n");
            Console.WriteLine("Введите числа, используя пробел для разделения:");
            List<int> numbers = new List<int>();
            numbers = Tools.IntLine();
            Console.WriteLine(numbers.Max());
        }
        public static void Num8()
        {
            Console.WriteLine("Формулировка: Вывести название дня недели по его номеру.\n");
            Console.WriteLine("Введите номер дня недели:");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }

        }
        public static void Num9()
        {
            Console.WriteLine(@"Формулировка. Дано четырехзначное число. Проверить, является ли оно палиндромом.
Примечание: палиндромом называется число, слово или текст, которые одинакового читаются слева 
направо и справа налево. Например, в нашем случае это числа 1441, 5555, 7117 и т. д.
");
            Console.WriteLine("Введите четырехзначное число");
            string num = Console.ReadLine();
            Console.WriteLine(num[0].ToString() + num[1].ToString() == num[3].ToString() + num[2].ToString());
        }
        public static void Num10()
        {
            Console.WriteLine(@"Формулировка: Дано четырехзначное число. Проверить, является ли оно «счастливым билетом». 
Примечание: счастливым билетом называется число, в котором: а) при четном количестве цифр 
в числе сумма цифр его левой половины равна сумме цифр его правой половины; б) при нечетном 
количестве цифр – то же самое, но с отбрасыванием серединной цифры.
");
            Console.WriteLine("Введите четырехзначное число:");
            string num = Console.ReadLine();
            int left = Convert.ToInt32(num[0].ToString()) + Convert.ToInt32(num[1].ToString()),
                right = Convert.ToInt32(num[2].ToString()) + Convert.ToInt32(num[3].ToString());
            Console.WriteLine(left == right);
        }
        public static void Num11()
        {
            Console.WriteLine(@"Формулировка: Дано число типа byte. Проверить, является ли палиндромом его двоичное 
представление с учетом того, что сохранены старшие нули. Пример таких чисел: 102 (т. к. 
102 = 0110 0110_2, а это палиндром), 129 (129 = 1000 0001_2) и т. д.
");
            Console.WriteLine("Введите число(меньше 256):");
            byte num = Convert.ToByte(Console.ReadLine()), part = 0;
            for (int i = 0; i < 4; i++)
            {
                part += Convert.ToByte(Convert.ToInt32(num % 2) * Math.Pow(2 ,3 - i));
                num /= 2;
            }
            Console.WriteLine(num == part);
        }
        public static void Num12()
        {
            Console.WriteLine(@"Формулировка: Даны вещественные числа a, b и c, причем a отлично от 0. Решить квадратное
уравнение ax2 + bx + c = 0 или сообщить о том, что действительных решений нет.
");
            Console.WriteLine("Введите a, b и c, разделяя их пробелом:");
            List<int> nums = new List<int>();
            nums = Tools.IntLine();
            int D = nums[1] * nums[1] - 4 * nums[0] * nums[2];
            if (D > 0) Console.WriteLine("x1 = {0}; x2 = {1}", (Math.Sqrt(D) - nums[1]) / (2 * nums[0]), (-1 * Math.Sqrt(D) - nums[1]) / (2 * nums[0]));
            else if (D == 0) Console.WriteLine("x = {0}", (-1 * nums[1]) / (2 * nums[0]));
            else Console.WriteLine("Нет действительных корней");
        }
        public static void Num13()
        {
            Console.WriteLine("Формулировка: Дано натуральное число. Вывести на экран все натуральные числа до заданного включительно.\n");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++) Console.Write("{0} ", i);
        }
        public static void Num14()
        {
            Console.WriteLine(@"Формулировка: Дано натуральное число. Найти его наибольший нетривиальный делитель или вывести 
единицу, если такового нет.
Примечание 1: делителем натурального числа a называется натуральное число b, на которое a делится 
без остатка. То есть выражение «b – делитель a» означает: a / b = k, причем k – натуральное число.
Примечание: нетривиальным делителем называется делитель, который отличен от 1 и от самого
числа (так как на единицу и само на себя делится любое натуральное число).
");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine()), i;
            for (i = num / 2; i > 0; i--) if (num % i == 0) break;
            Console.WriteLine(i);
        }
        public static void Num15()
        {
            Console.WriteLine(@"Формулировка: Дано натуральное число. Найти его наименьший нетривиальный делитель или вывести 
само это число, если такового нет.");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine()), i;
            for (i = 2; i <= num; i++) if (num % i == 0) break;
            Console.WriteLine(i);

        }
        public static void Num16()
        {
            Console.WriteLine("Формулировка: Дано натуральное число. Подсчитать общее количество его делителей.\n");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine()), count = 0;
            for (int i = 1; i <= num; i++) if (num % i == 0) count++;
            Console.WriteLine(count);
        }
        public static void Num17()
        {
            Console.WriteLine(@"Формулировка: Дано натуральное число. Проверить, является ли оно простым. 
Примечание: простым называется натуральное число, которое имеет ровно два различных натуральных 
делителя: единицу и само это число.
");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine()), count = 0;
            for (int i = 1; i <= num; i++) if (num % i == 0) count++;
            Console.WriteLine(count == 2);

        }
        public static void Num18()
        {
            Console.WriteLine("Формулировка: Дано натуральное число. Вывести на экран все простые числа до заданного включительно.\n");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine()), count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i == 2) count++;
                else if (Tools.Prime(i)) count++;
                else continue;
            }
            Console.WriteLine(count);
        }
        public static void Num19()
        {
            Console.WriteLine("Формулировка: Дано натуральное число n. Вывести на экран n первых простых чисел.\n");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine()), count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (Tools.Prime(i)) Console.Write(i + " ");
            }
        }
        public static void Num20()
        {
            Console.WriteLine(@"Формулировка: Дано натуральное число. Проверить, является ли оно совершенным.
Примечание: совершенным числом называется натуральное число, равное сумме всех своих собственных
делителей(то есть натуральных делителей, отличных от самого числа).
");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine()), sum = 0;
            for (int i = 1; i < num; i++) if (num % i == 0) sum += i;
            Console.WriteLine(sum == num);
        }
        public static void Num21()
        {
            Console.WriteLine(@"Формулировка: Даны два натуральных числа. Проверить, являются ли они дружественными.
Примечание: дружественными числами называются два различных натуральных числа, для которых сумма
всех собственных делителей первого числа равна второму числу и сумма всех собственных делителей 
второго числа равна первому числу.
");
            Console.WriteLine("Введите два числа, разделяя их пробелом:");
            List<int> friend = new List<int>();
            int sum0 = 0, sum1 = 0;
            friend = Tools.IntLine();
            for (int i = 1; i < friend[0]; i++) if (friend[0] % i == 0) sum0 += i;
            for (int i = 1; i < friend[1]; i++) if (friend[1] % i == 0) sum1 += i;
            Console.WriteLine((sum0 == friend[1]) && (sum1 == friend[0]));

        }
        public static void Num22()
        {
            Console.WriteLine(@"Формулировка: Даны два натуральных числа. Найти их наибольший общий делитель.
Примечание: наибольшим общим делителем двух натуральных чисел m и n называется наибольший из их
общих делителей. Обозначение: НОД(m, n).
Примечание 2: общим делителем двух натуральных чисел называется натуральное число, на которое 
натуральное число, которое является делителем обоих этих чисел.
");
            Console.WriteLine("Введите два числа, разделяя их пробелом:");
            List<int> nums = new List<int>();
            nums = Tools.IntLine();
            Console.WriteLine(Tools.GCD(nums[0], nums[1]));
        }
        public static void Num23()
        {
            Console.WriteLine(@"Формулировка: Даны два натуральных числа. Найти их наименьшее общее кратное.
Примечание: наименьшим общим кратным двух чисел m и n называется наименьшее натуральное число,
которое делится на m и n.
");
            Console.WriteLine("Введите два числа, разделяя их пробелом:");
            List<int> nums = new List<int>();
            nums = Tools.IntLine();
            Console.WriteLine(nums[0] * nums[1] / Tools.GCD(nums[0], nums[1]));
        }
        public static void Num24()
        {
            Console.WriteLine("Формулировка: Даны натуральные числа x и n (которое также может быть равно 0). Вычислить x^n.\n");
            Console.WriteLine("Введите число x и его степень n, разделяя их пробелом:");
            List<int> nums = new List<int>();
            nums = Tools.IntLine();
            Console.WriteLine(Tools.Mod(nums[0], nums[1]));
        }
        public static void Num25()
        {
            Console.WriteLine("Формулировка: Даны натуральные числа x и n. Вычислить x^n, используя алгоритм быстрого возведения в степень.\n");
            Console.WriteLine("Введите число x и его степень n, разделяя их пробелом:");
            List<int> nums = new List<int>();
            nums = Tools.IntLine();
            if (nums[1] % 2 == 0) Console.WriteLine(Tools.Mod(Tools.Mod(nums[0], 2), nums[1] / 2));
            else Console.WriteLine(nums[0] * Tools.Mod(Tools.Mod(nums[0], 2), nums[1] / 2));
        }
        public static void Num26()
        {
            Console.WriteLine("Формулировка: Дано натуральное число n. Вывести на экран решения всех квадратных уравнений вида x^2 + 2ax – 3 = 0 для всех a от 1 до n.\n");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            double sqrt;
            for (int a = 1; a <= num; a++)
            {
                sqrt = Math.Sqrt(a * a + 3);
                Console.WriteLine("При a {0} x1 = {1}; x2 = {2}", a, (-1 * a + sqrt), (-1 * a - sqrt));
            }
        }
        public static void Num27()
        {
            Console.WriteLine("Формулировка: Дано натуральное число n, вещественное число x и набор вещественных чисел a_n, a_n-1, ..., a_0. Вычислить значение многочлена n-ной степени с коэффициентами a_n, a_n-1, ..., a_0 от одной переменной в точке x.\n");
            Console.WriteLine("Введите n и x, используя Enter для разделения, и строку чисел a_n ... a_0, разделяя их пробелом");
            int n = Convert.ToInt32(Console.ReadLine()), x = Convert.ToInt32(Console.ReadLine()), value = 0;
            List<int> coef = new List<int>();
            coef = Tools.IntLine();
            for (int i = 0; i <= n; i++)
            {
                value = value * x + coef[n - i];
            }
            Console.WriteLine(value);
        }
        public static void Num28()
        {
            Console.WriteLine(@"Формулировка: Дано натуральное число n (которое также может быть равно нулю). Вычислить n!
Примечание: n! – произведение всех натуральных чисел до n включительно.
");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Tools.Fact(num));
        }
        public static void Num29()
        {
            Console.WriteLine("Формулировка: Даны натуральные числа n и k (k не превышает n). Вычислить число сочетаний из n по k.\n");
            Console.WriteLine("Введите n и k, используя Enter для разделения:");
            int n = Convert.ToInt32(Console.ReadLine()), k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Tools.Fact(n)/(Tools.Fact(k)* Tools.Fact(n-k)));
        }
        public static void Num30()
        {
            Console.WriteLine(@"Формулировка: Дано натуральное число n, меньшее 256. Используя псевдографику, вывести на экран таблицу квадратов и кубов всех натуральных чисел от 1 до n включительно.
Примечание: псевдографика – это совокупность символов для формирования видимых графических примитивов (линий, прямоугольников, рамок, таблиц и т. д.). Она была актуальна в те далекие времена, когда устройства вывода компьютеров не способны были работать с графикой, либо это было проблематично.
");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(@"/--------------------------------------------------------\");
            Console.WriteLine("|        x         |       x^2        |       x^3        |");
            Console.WriteLine("|--------------------------------------------------------|");
            for (int i = 1; i <= num; i++) Console.WriteLine("|{0,9}         |{1,9}         |{2,9}         |", i, Tools.Mod(i, 2), Tools.Mod(i, 3));
            Console.WriteLine(@"\--------------------------------------------------------/");
        }
        public static void Num31()
        {
            Console.WriteLine("Формулировка: Дано натуральное число n заранее неизвестной разрядности. Сформировать и вывести на экран число, представляющее собой реверсную запись n.\n");
            Console.WriteLine("Введите число:");
            string num0 = Console.ReadLine(), num1 = null;
            for (int i = num0.Length - 1; i >= 0; i--) num1 += num0[i];
            Console.WriteLine(num1);
        }
        public static void Num32()
        {
            Console.WriteLine(@"Формулировка: Дано натуральное число n. Проверить, представляют его ли цифры его восьмеричной записи строго монотонную последовательность. При этом последовательность из одной цифры считать строго монотонной.
Примечание: в математике строго возрастающие и строго убывающие последовательности называются строго монотонными. В строго возрастающей последовательности каждый следующий член больше предыдущего.
");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine()), octnum = Tools.DecTo(num, 8);
            bool Key = true;
            for (int i = 0; i < octnum.ToString().Length-1; i++)
            {
                if (Convert.ToInt32(octnum.ToString()[0]) > Convert.ToInt32(octnum.ToString()[1]))
                {
                    if (Convert.ToInt32(octnum.ToString()[i]) <= Convert.ToInt32(octnum.ToString()[i + 1]))
                    {
                        Key = false;
                        break;
                    }
                }
                else if (Convert.ToInt32(octnum.ToString()[0]) < Convert.ToInt32(octnum.ToString()[1]))
                {
                    if (Convert.ToInt32(octnum.ToString()[i]) >= Convert.ToInt32(octnum.ToString()[i + 1]))
                    {
                        Key = false;
                        break;
                    }
                }
            }
            Console.WriteLine(Key);
        }
        public static void Num33()
        {
            Console.WriteLine("Формулировка: Дано натуральное число n (n > 1). Получить его каноническое разложение на простые сомножители, то есть представить в виде произведения простых сомножителей. При этом в разложении допустимо указывать множитель 1. \n");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine()), i = 2;
            Console.Write("{0} = 1", num);
            while (num != 1)
            {
                if (num % i == 0)
                {
                    Console.Write(" * {0}", i);
                    num /= i;
                }
                else i++;
            }
        }
        public static void Num34()
        {
            Console.WriteLine("Формулировка: Даны два натуральных числа одинаковой десятичной разрядности. Сформировать из них третье число так, чтобы цифры первого числа стояли на нечетных местах третьего, а цифры второго – на четных. При этом порядки следования цифр сохраняются.\n");
            Console.WriteLine("Введите числа, используя пробел для разделения:");
            List<int> num = new List<int>();
            num = Tools.IntLine();
            string result = null;
            for (int i = 0; i < num[0].ToString().Length; i++) result += num[0].ToString()[i].ToString() + num[1].ToString()[i].ToString();
            Console.WriteLine(result);
        }
        public static void Num35()
        {
            Console.WriteLine("Формулировка: Даны натуральные числа x и n (n <= 10). Вывести на экран число x, записанное в системе счисления с основанием n.\n");
            Console.WriteLine("Введите число x и основание степени n, используя пробел для разделения:");
            List<int> nums = new List<int>();
            nums = Tools.IntLine();
            Console.WriteLine(Tools.DecTo(nums[0], nums[1]));
        }
        public static void Num36()
        {
            Console.WriteLine("Формулировка: Даны натуральные числа m и n. Вывести на экран их наименьший нетривиальный делитель или сообщить, что его нет.\n");
            Console.WriteLine("Введите числа m и n, используя пробел для разделения:");
            List<int> nums = new List<int>();
            nums = Tools.IntLine();
            int mindiv = 0;
            for (int i = 2; i <= Math.Min(nums[0], nums[1]); i++)
            {
                if ((nums[0] % i == 0) && (nums[1] % i == 0))
                {
                    mindiv = i;
                    break;
                }
            }
            if (mindiv > 0) Console.WriteLine(mindiv);
            else Console.WriteLine("Нет делителей");
        }
        public static void Num37()
        {
            Console.WriteLine("Формулировка: Дано натуральное число n. Проверить, является ли оно счастливым билетом.\n");
            Console.WriteLine("Введите число:");
            string num = Console.ReadLine();
            int left = 0, right = 0;
            for (int i = 0; i < num.Length/2; i++)
            {
                left += Convert.ToInt32(num[i].ToString());
                right += Convert.ToInt32(num[num.Length - 1 - i].ToString());
            }
            Console.WriteLine(left == right);
        }
        public static void Num38()
        {
            Console.WriteLine("Формулировка: Дано натуральное число n. Проверить, представляет ли собой палиндром его десятичная запись.\n");
            Console.WriteLine("Введите число:");
            string num = Console.ReadLine(), left = null, right = null;
            for (int i = 0; i < num.Length / 2; i++)
            {
                left += num[i].ToString();
                right += num[num.Length - 1 - i].ToString();
            }
            Console.WriteLine(left == right);
        }
        public static void Num39()
        {
            Console.WriteLine("Формулировка: Дано натуральное число n. Проверить, представляет ли оно собой натуральную степень числа 2.\n");
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 1)
            {
                if (num%2 == 1) break;
                num /= 2;
            }
            Console.WriteLine(num == 1);
        }
        public static void Num40()
        {
            Console.WriteLine("Формулировка: Дана последовательность натуральных чисел, ограниченная вводом нуля. Вывести на экран произведение четных элементов этой последовательности. При этом ноль не считается членом последовательности.\n");
            Console.WriteLine("Введите последовательность чисел, используя для разделения Enter, закончите ввод нулем:");
            int num = Convert.ToInt32(Console.ReadLine()), comp = 1;
            while (num != 0)
            {
                if (num%2 == 0) comp *= num;
                num = Convert.ToInt32(Console.ReadLine());
            }
            if (comp != 1) Console.WriteLine(comp);
            else Console.WriteLine("Нет четных элементов");
        }
        public static void Num41()
        {
            Console.WriteLine("Формулировка: Дано натуральное число n, а затем последовательность натуральных чисел, ограниченная вводом нуля. Вывести на экран произведение двузначных элементов этой последовательности, которые делятся на n.\n");
            Console.WriteLine("Введите число n и последовательность чисел, используя для разделения Enter, закончите ввод нулем:");
            int n = Convert.ToInt32(Console.ReadLine()), num = Convert.ToInt32(Console.ReadLine()), comp = 1;
            while (num != 0)
            {
                if ((num > 9) && (num < 100) && (num % n == 0)) comp *= num;
                num = Convert.ToInt32(Console.ReadLine());
            }
            if (comp != 1) Console.WriteLine(comp);
            else Console.WriteLine("Нет таких элементов");
        }
        public static void Num42()
        {
            Console.WriteLine("Формулировка: Дана последовательность натуральных чисел, ограниченная вводом нуля. Вывести на количество простых членов этой последовательности.\n");
            Console.WriteLine("Введите последовательность чисел, используя для разделения Enter, закончите ввод нулем:");
            int num = Convert.ToInt32(Console.ReadLine()), count = 0;
            while (num != 0)
            {
                if (Tools.Prime(num)) count ++;
                num = Convert.ToInt32(Console.ReadLine());
            }
            if (count != 0) Console.WriteLine(count);
            else Console.WriteLine("Нет простых элементов");

        }
        public static void Num43()
        {
            Console.WriteLine("Формулировка: Дана последовательность натуральных чисел, ограниченная вводом нуля. Проверить, начинается ли каждый из ее членов (со второго) с десятичной цифры, на которую оканчивается предыдущий\n");
            Console.WriteLine("Введите последовательность чисел, используя для разделения Enter, закончите ввод нулем:");
            string num = Console.ReadLine();
            char digit = num[num.Length-1];
            while (num != "0")
            {
                num = Console.ReadLine();
                if (num[0] == digit) digit = num[num.Length - 1];
                else
                {
                    if (num != "0") digit = ' ';
                    break;
                }
            }
            Console.WriteLine(digit != ' ');
        }
        public static void Num44()
        {
            Console.WriteLine(@"Формулировка: Дана последовательность из трех и более натуральных чисел, ограниченная вводом нуля. Проверить, является ли эта последовательность пилообразной.
Примечание: пилообразной называется последовательность чисел, в которой каждый член, имеющий соседние члены, меньше или больше их.
");
            Console.WriteLine("Введите последовательность чисел, используя для разделения Enter, закончите ввод нулем:");
            int num1 = Convert.ToInt32(Console.ReadLine()),
                num2 = Convert.ToInt32(Console.ReadLine()),
                num3 = Convert.ToInt32(Console.ReadLine());
            while (num3 != 0)
            {
                if ((num1 - num2)*(num3 - num2) > 0)
                {
                    num1 = num2;
                    num2 = num3;
                    num3 = Convert.ToInt32(Console.ReadLine());
                }
                else break;
            }
            if (num3 == 0) Console.WriteLine(1 == 1);
            else Console.WriteLine((num1 - num2) * (num3 - num2) > 0);
        }
        public static void Num45()
        {
            Console.WriteLine("Формулировка: Дана последовательность натуральных чисел, ограниченная вводом нуля. Проверить, является ли эта последовательность строго монотонной.\n");
            Console.WriteLine("Введите последовательность чисел, используя для разделения Enter, закончите ввод нулем:");
            int prenum = Convert.ToInt32(Console.ReadLine()), num = Convert.ToInt32(Console.ReadLine()), dif = num - prenum;
            bool Key = false;
            while (num != 0)
            {
                if (dif < 0)
                {
                    if (num >= prenum) break;
                }
                else if (dif > 0)
                {
                    if (num <= prenum) break;
                }
                else if (dif == 0) break;
                prenum = num;
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0) Key = true;
            }
            Console.WriteLine(Key);
        }
        public static void Num46()
        {
            Console.WriteLine("Формулировка: Дано натуральное n (которое также может быть равно 0). Вывести на экран n-ное число Фибоначчи.\n");
            Console.WriteLine("Введите число n:");
            int num = Convert.ToInt32(Console.ReadLine()), fib0 = 0, fib1 = 1, fibcur;
            for (int i = 2; i <= num; i++)
            {
                fibcur = fib0 + fib1;
                fib0 = fib1;
                fib1 = fibcur;
            }
            if (num == 0) fib1 = 0;
            Console.WriteLine(fib1);
        }
        public static void Num47()
        {
            Console.WriteLine("Формулировка: Дано натуральное n (которое также может быть равно 0). Вывести на экран сумму чисел Фибоначчи до n-ного включительно. Например, при n = 3 нам необходимо получить сумму 0-го, 1-го, 2-го и 3-го членов последовательности.\n");
            Console.WriteLine("Введите число n:");
            int num = Convert.ToInt32(Console.ReadLine()), fib0 = 0, fib1 = 1, fibcur, fibsum = fib1;
            for (int i = 2; i <= num; i++)
            {
                fibcur = fib0 + fib1;
                fib0 = fib1;
                fib1 = fibcur;
                fibsum += fibcur;
            }
            if (num == 0) fibsum = 0;
            Console.WriteLine(fibsum);
        }
        public static void Num48()
        {
            Console.WriteLine("Формулировка: Дано натуральное n (которое также может быть равно 0). Вывести на экран все числа Фибоначчи до n-ного включительно.\n");
            Console.WriteLine("Введите число n:");
            int num = Convert.ToInt32(Console.ReadLine()), fib0 = 0, fib1 = 1, fibcur;
            Console.Write(fib0 + " ");
            if (num > 0) Console.Write(fib1 + " ");
            for (int i = 2; i <= num; i++)
            {
                fibcur = fib0 + fib1;
                fib0 = fib1;
                fib1 = fibcur;
                Console.Write(fib1 + " ");
            }
        }
        public static void Num49()
        {
            Console.WriteLine(@"Формулировка. Дана последовательность символов длины n (n >= 1). Проверить баланс круглых скобок в этом выражении. Например, при вводе выражения (())() программа должна сообщить о правильности расстановки скобок, а при вводе выражения ((()) – о неправильности.
Примечание: сбалансированной скобочной записью называется символьное выражение, в котором каждой открывающей скобке соответствует закрывающая скобка правее и наоборот, каждой закрывающей скобке соответствует открывающая скобка левее.
");
            Console.WriteLine("Введите число n, и строку симполов, используя для разделения числа и строки Enter:");
            int num = Convert.ToInt32(Console.ReadLine()), count = 0;
            string line = Console.ReadLine();
            for (int i = 0; i < num; i++)
            {
                if (line[i] == '(') count += 1;
                else if (line[i] == ')') count -= 1;
            }
            Console.WriteLine(count == 0);
        }
        public static void Num50()
        {
            Console.WriteLine("Формулировка: Дано действительное число x. Вычислить значение экспоненциальной функции (то есть, показательной функции e^x, где e – математическая константа, e ~ 2,718281828459045) в точке x с заданной точностью eps с помощью ряда Тейлора.\n");
            Console.WriteLine("Введите число x и точность, используя Enter для разделения");
            double x = Convert.ToDouble(Console.ReadLine()), eps = Convert.ToDouble(Console.ReadLine()), result = 1, part = 1;
            int count = 1;
            while (Math.Abs(part) >= eps)
            {
                part *= x/count;
                result += part;
                count++;
            }
            Console.WriteLine(result);
        }
    }
}
