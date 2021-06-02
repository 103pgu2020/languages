using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Программа, которая выводи трёхназчные числа, сумма цифр которых меньше заданного n");
        m: Console.WriteLine("Вв-те n");
            double n = Convert.ToDouble(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Вв-те положительное n");
                goto m;
            }
            for (int i = 100; i < 1000; i++)
            {
                a = i / 100;
                b = i / 10 % 10;
                c = i % 10;
                if ((a + b + c) < n)
                    Console.WriteLine(i);
            }
            Console.WriteLine("Повторить? 1-Да; Любое другое число-нет.");
            int l = Convert.ToInt32(Console.ReadLine());
            if (l == 1)
                goto m;
            return;

        }
    }
}