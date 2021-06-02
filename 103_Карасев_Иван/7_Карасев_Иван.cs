using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Карасев_Иван_7
{
    class Program
    {
        static void Main(string[] args)
        {
         m1:int a, b, c;
            for (int i = 100; i < 1000; i++)
            {
                a = i / 100;
                b = i / 10 % 10;
                c = i % 10;
                if (a == b && a != c || a == c && a != b || b == c && b != a)
                    Console.WriteLine(i);
            }
            Console.Write("Ещё раз? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}