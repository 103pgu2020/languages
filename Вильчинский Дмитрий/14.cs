using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main()
        {
        m: Console.Write("Введите натуральное N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            double a = 0, count = 0;
            Console.Write("Введите действительное x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (N < 0 || x < 0)
            {
                Console.WriteLine("Ошибка.");
                goto m;
            }
            for (int i = 1; i <= N; i++)
            {
                count++;
                if (i % 2 == 0)
                {
                    count--;
                    continue;
                }
                int fk = 1;
                for (int j = 1; j <= i; j++)
                    fk *= j;
                if (count % 2 != 0)
                    a += Math.Pow(x, i) / fk;
                else
                    a -= Math.Pow(x, i) / fk;
            }
            Console.WriteLine("Сумма ряда = {0:0.000}", a);
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t == 1) goto m;
            return;
        }
    }
}