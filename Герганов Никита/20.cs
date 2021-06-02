using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Получить таблицу пересчета миль в километры и обратно (1 миля = 1.609344) для расстояний, не превышающих k км.");
       m1:  Console.Write("Введите k: ");
            double mile = 1.609344,
                   q = 1.0;
            double k = Double.Parse(Console.ReadLine());
            if (k < 0) { Console.WriteLine("Ошибка! Введите другое значение!"); goto m1; }
            Console.WriteLine("  мили |  км");
            for (double i = 1; i <= Math.Floor(k); i++)
            {
                if (i / 1.609344 < q) Console.WriteLine("{0,6:0.0000} | {1:0.0000}", i / mile, i);
                else
                {
                    if (q * 1.609344 <= k) Console.WriteLine("{0,6:0.0000} | {1:0.0000}", q, q * mile);
                    if (i <= k) Console.WriteLine("{0,6:0.0000} | {1:0.0000}", i / mile, i);
                    q++;
                }
            }
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            int u = Int32.Parse(Console.ReadLine());
            if (u == 1) goto m1;
            return;
        }
    }
}
