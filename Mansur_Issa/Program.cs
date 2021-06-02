using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();

            Console.WriteLine("Введите время, в которое начинается учебный день в формате ЧЧ:ММ");
            string str = Console.ReadLine();
            int h = Convert.ToInt32(str.Substring(0,2));
            int m = Convert.ToInt32(str.Substring(3));
            int s = h * 60 + m;
            Console.WriteLine("Введите количество уроков (пар):");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длительность уроков (пар) в минутах:");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длительность перемен в минутах:");
            m = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++,  s = (s + h) % 1440 + m)
                Console.WriteLine(i + " урок: {0:00}:{1:00} - {2:00}:{3:00}", s/60, s%60, (s+h)/60%24, (s+h)%60);

            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}
