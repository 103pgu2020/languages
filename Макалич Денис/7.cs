using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
        m: Console.WriteLine("Программа, которая выводи на экран трёхнзначные числа с ДВУМЯ одинаковыми цифрами");
            for (int i = 100; i < 1000; i++)
            {
                a = i / 100;
                b = i / 10 % 10;
                c = i % 10;
                if ((a == b || a == c) || (b == a || b == c))
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