using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double k, s, count = 0, p,m;
        m1: Console.WriteLine("Введите стартовый капитал (положительный): ");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процент (положительный): ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конечную сумму S (положительный): ");
            s = Convert.ToDouble(Console.ReadLine());
            if (k > 0 && p > 0 && s > 0)
            {
                count = 0;
                while (k <= s)
                {
                    count++;
                    k = k + k * p / 100;
                }
                Console.WriteLine("Через {0} месяцев он накопит сумму {1}", count, s);
            }
            else
            {
                Console.WriteLine("Вводные числа должны быть положительными");
            }
            Console.WriteLine("Если хотите повторить программу введите '1'");
            m = Convert.ToInt32(Console.ReadLine());
            if (m == 1)
            {
                goto m1;
            }
            Console.ReadLine();
            return;
        }
    }
}
