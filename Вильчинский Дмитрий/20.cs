using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main()
        {
        m: Console.Write("Введите k: ");
            double k = Double.Parse(Console.ReadLine());
            if (k < 0)
            {
                Console.WriteLine("Ошибка! Введите другое значение!");
                goto m;
            }
            double mile = 1.609344,
                   km = 1.0;

            Console.WriteLine("|  мили |  км   |");
            for (double i = 1; i <= Math.Floor(k); i++)
            {
                if (i / 1.609344 < km) Console.WriteLine("|{0,6:0.0000} | {1:0.0000}|", i / mile, i);
                else
                {
                    if (km * 1.609344 <= k) Console.WriteLine("|{0,6:0.0000} | {1:0.0000}|", km, km * mile);
                    if (i <= k) Console.WriteLine("|{0,6:0.0000} | {1:0.0000}|", i / mile, i);
                    km++;
                }
            }
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1) goto m;
            return;
        }
    }
}