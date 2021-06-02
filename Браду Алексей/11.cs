using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, m1, m2, k, i = 0;
         m:   Console.WriteLine("Программа- расписание уроков");
        m1: Console.WriteLine("Время начала уроков ");
            Console.Write("Часов: ");
            h = Convert.ToInt16(Console.ReadLine());
            Console.Write("Минут: ");
            m = Convert.ToInt16(Console.ReadLine());
            Console.Write("Уроки дляться минут: ");
            m1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Перерывы дляться минут: ");
            m2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Кол-во уроков: ");
            k = Convert.ToInt16(Console.ReadLine());
            if (h > 23 || h < 0 || m > 59 || m < 0 || m1 < 1 || m2 < 1 || k < 0)
            {
                Console.WriteLine("Ошибка ввода повторите ещё");
                goto m1;
            }
            for (i = 1; i <= k; i++)
            {
                Console.Write("{0}) {1:00}.{2:00} -", i, h, m);
                h = (h + (m + m1) / 60) % 24;
                m = (m + m1) % 60;
                Console.WriteLine(" {0:00}.{1:00}", h, m);
                h = (h + (m + m2) / 60) % 24;
                m = (m + m2) % 60;
            }
            Console.ReadKey();
            Console.WriteLine("Повторить? 1-Да; Любое другое число-нет.");
            h = Convert.ToInt32(Console.ReadLine());
            if (h == 1)
                goto m;
            return;
        }
    }
}