using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести на экран все делители натурального N и их количество.");
        m1: Console.Write("Введите натуральное число N: ");
            int n, count = 0;
            n = Int32.Parse(Console.ReadLine());
            if (n < 1)
                { Console.WriteLine("Ошибка!"); goto m1; }
            Console.WriteLine("Делители:");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine("Количество делителей: " + count);
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            int u = Int32.Parse(Console.ReadLine());
            if (u == 1) goto m1;
            return;
        }
    }
}
