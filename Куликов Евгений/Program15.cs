using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd15
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());
            if (k < 1)
            {
                Console.WriteLine("Введите число согласно условию");
                goto m1;
            }
            int a = 1;
            int b = 1;
            int c;
            Console.Write($"{a} {b} ");
            for (int i = 0; i < k - 2; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write($"{c} ");
            }
            Console.Write("\n\nЕщё раз? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}