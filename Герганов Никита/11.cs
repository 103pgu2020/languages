using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В учебном заведении задаётся начало учебного дня, продолжительность пары, продолжительность перерывов, количество пар (уроков). Получить расписание звонков на весь учебный день");
        m1: Console.WriteLine("Время начала пар:");
            int h, m, m_lesson, m_break, k;
            Console.Write("Часы: ");
            h = Int32.Parse(Console.ReadLine());
            Console.Write("Минуты: ");
            m = Int32.Parse(Console.ReadLine());
            Console.Write("Продолжительность пары (минут): ");
            m_lesson = Int32.Parse(Console.ReadLine());
            Console.Write("Продолжительность перерывов (минут): ");
            m_break = Int32.Parse(Console.ReadLine());
            Console.Write("Количество пар: ");
            k = Int32.Parse(Console.ReadLine());
            if (m_lesson < 0 || m_break < 0 || m > 60 || m < 0 || k < 0 || h > 24 || h < 0)
                { Console.WriteLine("Ошибка!"); goto m1; }
            for (int i = 1; i <= k; i++)
            {
                Console.Write("{0}. {1:00}:{2:00} -", i, h, m);
                h = (h + (m + m_lesson) / 60) % 24;
                m = (m + m_lesson) % 60;
                Console.WriteLine(" {0:00}:{1:00}", h, m);
                h = (h + (m + m_break) / 60) % 24;
                m = (m + m_break) % 60;
            }
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            int u = Int32.Parse(Console.ReadLine());
            if (u == 1) goto m1;
            return;
        }
    }
}
