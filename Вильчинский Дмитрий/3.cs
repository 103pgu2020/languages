using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
        m:
            Console.Clear();
            Console.WriteLine("Ввeдите последовательность:");
            int k = 0;
            double x, y = 0;
            while ((x = Double.Parse(Console.ReadLine())) != 0)
            {
                if (x * y < 0)
                    k++;
                y = x;
            }
            Console.WriteLine("Количество смен знаков: " + k);
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            k = Int32.Parse(Console.ReadLine());
            if (k == 1)
                goto m;
        }
    }
}