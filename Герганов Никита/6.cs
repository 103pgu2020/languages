using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести все трехзначные числа, сумма цифр которых меньше заданного N");
        m1: Console.Write("Введите N: ");
            int n = Int32.Parse(Console.ReadLine());
            if (n < 0) { Console.WriteLine("Введите другое значение!"); goto m1; }
            for (int i = 100; i < 1000; i++)
                if (i / 100 + i % 100 / 10 + i % 10 < n)
                    Console.WriteLine(i);
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            int u = Int32.Parse(Console.ReadLine());
            if (u == 1) goto m1;
            return;
        }
    }
}