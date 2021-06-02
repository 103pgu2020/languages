using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Карасев_Иван_18
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());
            if (N < 1)
            {
                Console.WriteLine("Введённое число не подходит по условию");
                goto m1;
            }
            int c = 2;
            for (int i = 1; i <= N / 10; i++)
            {
                if (i % 3 != 0)
                    c *= 2;
            }
            Console.WriteLine(c);
            Console.Write("\nЕщё раз? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}
