using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: int c = 0;
            int p = 0;
            while (true)
            {
                Console.Write("Число: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                    break;
                else
                {
                    if (p * n < 0 && p != 0)
                        c++;
                    p = n;
                }
            }
            Console.WriteLine($"Кол-тво смен знаков: {c}");
            Console.Write("Повторить? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}