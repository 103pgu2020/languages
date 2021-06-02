using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести все трехзначные числа, в которых две одинаковые цифры");
            for (int i = 100; i < 1000; i++)
                if (i / 100 == i % 100 / 10 || i % 100 / 10 == i % 10 || i / 100 == i % 10) 
                    Console.WriteLine(i);
            Console.ReadKey();
            return;
        }
    }
}