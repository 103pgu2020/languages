using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Карасев_Иван_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0, i = 0, j = 0;
        m1: Console.WriteLine("Введите число n:");
            n = Convert.ToInt16(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Введите число согласно условию");
                goto m1;
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
            Console.Write("\nЕщё раз? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}
