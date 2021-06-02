using System;

namespace Языки7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
        m: Console.WriteLine("Программа выводящая на экран трёхнзначные числа с двумя одинаковыми цифрами");
            for (int i = 100; i < 1000; i++)
            {
                a = i / 100;
                b = i / 10 % 10;
                c = i % 10;
                if ((a == b || a == c) || (b == a || b == c))
                    Console.WriteLine(i);
            }
            Console.WriteLine("Повторить? 1-Да; Другое число-нет");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
                goto m;
            return;

        }
    }
}
