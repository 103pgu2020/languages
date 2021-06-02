using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Карасев_Иван_2
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: Console.Write("Стартовый капитал: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Ежемесячное процентное увеличение: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Сумма для накопления: ");
            int S = int.Parse(Console.ReadLine());
            int m = 0;
            if (k >= 0 && p > 0 && S >= k)
            {
                while (k <= S)
                {
                    k += k / 100 * p;
                    m++;
                    //Console.WriteLine($"Сумма накопится через {m} месяцев");
                }
                Console.WriteLine($"Сумма накопится через {m} месяцев");
            }
            //   Console.WriteLine($"Сумма накопится через {m} месяцев");
            else Console.WriteLine("Введите число согласно условию задачи");
            Console.Write("Ещё раз? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}