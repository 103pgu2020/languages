using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0, i = 0, j = 0;
        m:
            Console.Write("n: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Ошибка.");
                goto m;
            }
            Console.WriteLine("Простые числа:");
            for (i = 1; i < n; i++)
            {
                k = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        k++;
                }
                if (k <= 2) Console.WriteLine(i);
            }
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1) goto m;

        }
    }
}
