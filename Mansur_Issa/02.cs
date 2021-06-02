using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();
            double k, p, S;
            int i = 0;
            Console.WriteLine("Введите стартовый капитал:");
            k = Double.Parse(Console.ReadLine());
            if (k <= 0)
            {
                Console.WriteLine("Введите положительное число!");
                goto st;
            }
            Console.WriteLine("Введите процент:");
            p = Double.Parse(Console.ReadLine());
            if (p <= 0)
            {
                Console.WriteLine("Введите положительное число!");
                goto st;
            }
            Console.WriteLine("Введите сумму, которую надо накопить:");
            S = Double.Parse(Console.ReadLine());
            if (S <= 0)
            {
                Console.WriteLine("Введите положительное число!");
                goto st;
            }
            while (k < S)
            {
                k = k / 100.0 * (100 + p);
                i++;
            }
            Console.WriteLine("Количество месяцев, необходимых для достижения суммы:" + i);
            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            i = Int32.Parse(Console.ReadLine());
            if (i == 1)
                goto st;
        }
    }
}
