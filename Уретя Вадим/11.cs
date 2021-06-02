using System;


namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*В учебном заведении задаётся начало учебного дня, продолжительность пары,
            продолжительность перерывов, количество пар (уроков).
            Получить расписание звонков на весь учебный день.*/
            Console.WriteLine("Программа- расписание уроков");
        m1: Console.WriteLine("\nВремя начала уроков ");
            Console.Write("Часов: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Минут: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Уроки дляться минут: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Перерывы дляться минут: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кол-во уроков: ");
            int k = Convert.ToInt32(Console.ReadLine());
            if (h > 23 || h < 0 || m > 59 || m < 0 || m1 < 1 || m2 < 1 || k < 0)
            {
                Console.WriteLine("Ошибка ввода повторите ещё");
                goto m1;
            }
            for (int i = 1; i <= k; i++)
            {
                Console.Write("{0}) {1:00}.{2:00} -", i, h, m);
                h = (h + (m + m1) / 60) % 24;
                m = (m + m1) % 60;
                Console.WriteLine(" {0:00}.{1:00}", h, m);
                h = (h + (m + m2) / 60) % 24;
                m = (m + m2) % 60;
            }
            Console.WriteLine("\nПродолжить? (1 - да, другоче число - нет) ");
            if (Console.ReadLine() == "1")
                goto m1;
            return;
        }
    }
}
