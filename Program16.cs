using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
        m1: int n = rand.Next(1, 1001);
            Console.WriteLine("Загадано число от 1 до 1000");
            int a;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} попытка: ");
                a = int.Parse(Console.ReadLine());

                if (a > n)
                    Console.WriteLine("Загаданное число меньше\n");
                else if (a < n)
                    Console.WriteLine("Загаданное число больше\n");
                else
                {
                    Console.WriteLine("Угадали");
                    break;
                }
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