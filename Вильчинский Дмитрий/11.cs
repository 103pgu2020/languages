using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main()
        {
            Console.Write("Начало учебного дня: ");
            TimeSpan startDay = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Продолжительность пары: ");
            TimeSpan lessonDuration = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Продолжительность обычного перерыва: ");
            TimeSpan StandartInterval = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Продолжительность большого перерыва: ");
            TimeSpan BigInterval = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Его позиция: ");
            int indexBigInterval = int.Parse(Console.ReadLine());
            Console.Write("Кол-во уроков: ");
            int countLessons = int.Parse(Console.ReadLine());
            Console.WriteLine();

            TimeSpan time = startDay;
            for (int i = 1; i <= countLessons; i++)
            {
                Console.WriteLine("Урок " + i);
                Console.WriteLine("{0:hh\\:mm}", time);
                time = time.Add(lessonDuration);
                Console.WriteLine("{0:hh\\:mm}", time);
                Console.WriteLine();
                if (i != countLessons)
                {
                    Console.WriteLine("Перерыв:");
                    Console.WriteLine("{0:hh\\:mm}", time);
                    if (i != indexBigInterval)
                    {
                        time = time.Add(StandartInterval);
                        Console.WriteLine("{0:hh\\:mm}", time);
                    }
                    else
                    {
                        time = time.Add(BigInterval);
                        Console.WriteLine("{0:hh\\:mm}", time);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}