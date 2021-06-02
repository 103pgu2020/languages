using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, m1, m2, k, m3;
       m3:  Console.WriteLine("Программа расписание уроков");
       m1:  Console.WriteLine("Время начала уроков ");
            Console.WriteLine("Часов: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минут: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Уроки дляться минут: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Перерывы дляться минут: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кол-во уроков: ");
            k = Convert.ToInt32(Console.ReadLine());
            if (h > 23 || h < 0 || m > 59 || m < 0 || m1 < 1 || m2 < 1 || k < 0)
            {
                Console.WriteLine("Неверный ввод данных");
                goto m1;
            }
            for (int i = 1; i <= k; i++)
            {
                Console.Write("{0} урок: {1:00}.{2:00} - ", i, h, m);
                h = (h + (m + m1) / 60) % 24;
                m = (m + m1) % 60;
                Console.WriteLine("{0:00}.{1:00}", h, m);
                h = (h + (m + m2) / 60) % 24;
                m = (m + m2) % 60;
            }
            Console.WriteLine("Если хотите повторить программу введите '1'");
            m = Convert.ToInt32(Console.ReadLine());
            if (m == 1)
            {
                goto m3;
            }
            Console.ReadLine();
            return;
        }
    }
}
