using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main()
        {
        m: Console.Write("k: ");
            int k, a = 0, b = 1, s = 0, n = 1;
            k = Int32.Parse(Console.ReadLine());
            if (k < 0)
            {
                Console.WriteLine("Ошибка.");
                goto m;
            }
            while (n <= k)
            {
                s = a + b;
                a = b;
                b = s;
                n++;
                Console.Write(a + "|");
            }
            Console.WriteLine();
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1) goto m;
            return;
        }
    }
}