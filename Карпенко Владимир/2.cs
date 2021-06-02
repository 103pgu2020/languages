using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
        m:
            double k, p, S;
            int count = 0;
            Console.WriteLine("Введите стартовый капитал:");
            k = Double.Parse(Console.ReadLine());
            if (k <= 0)
            {
                Console.WriteLine("Введите положительное число.");
                goto m;
            }
            Console.WriteLine("Введите процент:");
            p = Double.Parse(Console.ReadLine());
            if (p <= 0)
            {
                Console.WriteLine("Введите положительное число.");
                goto m;
            }
            Console.WriteLine("Введите сумму, которую надо накопить:");
            S = Double.Parse(Console.ReadLine());
            if (S <= 0)
            {
                Console.WriteLine("Введите положительное число.");
                goto m;
            }
            while (k < S)
            {
                k = k / 100.0 * (100 + p);
                count++;
            }
            Console.WriteLine("Количество месяцев, необходимых для достижения суммы:" + count);
            Console.WriteLine("Введите 1 если хотите повторить, если нет другую цифру.");
            count = Int32.Parse(Console.ReadLine());
            if (count == 1)
                goto m;
        }
    }
}