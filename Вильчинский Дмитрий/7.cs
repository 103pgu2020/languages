using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main()
        {
        m:
            for (int i = 100; i <= 999; i++)
            {
                int a = i / 100;
                int b = i / 10 % 10;
                int c = i % 10;
                if ((a == b || b == c || a == c) && i % 111 != 0)
                    Console.Write(i + "|");
            }
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto m;
        }
    }
}