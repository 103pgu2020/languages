using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Карасев_Иван_1
{
    class Program
    {
        static void Main(string[] args)
        {
        n1: Console.Write("Число: ");
            long n = long.Parse(Console.ReadLine());
            int c = 0;
            do
            {
                n /= 10;
                c++;
            }
            while (n != 0);
            Console.WriteLine($"Кол-во цифр: {c}");
            Console.Write("Ещё раз? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto n1;
            }
        }
    }
}
