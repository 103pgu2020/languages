using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
        m1: int a, b, c;
            int d = 0;
            for (int i = 0; i < 10; i++)
            {
                a = rand.Next(1, 10);
                b = rand.Next(1, 10);
                Console.Write($"{a} * {b} = ");
                c = int.Parse(Console.ReadLine());
                if (c == a * b)
                    d++;
            }
            switch (d)
            {
                case 10:
                    Console.WriteLine($"Оценка: {d} - Отлично");
                    break;
                case 9:
                case 8:
                    Console.WriteLine($"Оценка: {d} - Хорошо");
                    break;
                case 7:
                case 6:
                    Console.WriteLine($"Оценка: {d} - Удовлетворительно");
                    break;
                default:
                    Console.WriteLine($"Оценка: {d} - Незачёт");
                    break;
            }
            Console.Write("\nЕщё раз? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}