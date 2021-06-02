using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();

            Random random = new Random();
            int N = random.Next(1000) + 1;

            Console.WriteLine("Привет, Игрок! Твоя цель угадать число от 1 до 1000 за 10 попыток.");
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Попытка №"+i);
                Console.WriteLine("Введите число:");
                int y = Int32.Parse(Console.ReadLine());
                if (y == N)
                {
                    Console.WriteLine("Угадал(а)");
                    break;
                }
                else
                    Console.WriteLine("Загаданное число " + (N > y ? "больше":"меньше"));
                Console.WriteLine();
            }

            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}
