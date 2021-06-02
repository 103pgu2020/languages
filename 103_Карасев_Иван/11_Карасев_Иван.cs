using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Карасев_Иван_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, a, b, c, k, i = 0;
            Console.WriteLine("Программа- расписание уроков");
        m1: Console.WriteLine("Время начала уроков ");
            Console.Write("Часов: ");
            h = Convert.ToInt16(Console.ReadLine());
            Console.Write("Минут: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Уроки длятся минут: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("Перерывы длятся минут: ");
            c = Convert.ToInt16(Console.ReadLine());
            Console.Write("Кол-во уроков: ");
            k = Convert.ToInt16(Console.ReadLine());
            if (h > 23 || h < 0 || a > 59 || a < 0 || b < 1 || c < 1 || k < 0)
            {
                Console.WriteLine("Неверно введены числа");
                goto m1;
            }
            for (i = 1; i <= k; i++)
            {
                Console.Write("{0}) {1:00}.{2:00} -", i, h, a);
                h = (h + (a + b) / 60) % 24;
                a = (a + b) % 60;
                Console.WriteLine(" {0:00}.{1:00}", h, a);
                h = (h + (a + c) / 60) % 24;
                a = (a + c) % 60;
            }
            Console.ReadKey();
        }
    }
}
