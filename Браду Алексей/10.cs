using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, c, k = 0;
            m:    for (i = 1; i <= 10; i++)
            {
                for (k = 1; k <= 10; k++)
                    Console.Write("     |");
                Console.WriteLine();
                for (j = 1; j <= 10; j++)
                {
                    c = i * j;
                    Console.Write(" {0,3} |", c);
                }
                Console.WriteLine();
                for (k = 1; k <= 60; k++)
                    Console.Write("_");
                Console.WriteLine();
            }
            Console.WriteLine("Повторить? 1-Да; Любое другое число-нет.");
            i = Int32.Parse(Console.ReadLine());
            if (i == 1)
                goto m;
            return;
        }
    }
}