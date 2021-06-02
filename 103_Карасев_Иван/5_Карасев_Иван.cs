using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Карасев_Иван_5
{
    class Program
    {
        static Random rand = new Random();
        static void Output()
        {
            double mean = 0;
            Console.Write("Последовательность (из 10 чисел): ");
            for (int i = 0; i < 10; i++)
            {
                int num = rand.Next(-100, 100);
                Console.Write($"{num} ");
                mean += num;
            }
            mean /= 10;
            Console.WriteLine($"\nСреднее арифметическое: {mean}\n");
        }
        static void Main(string[] args)
        {
        m1:
            for (int i = 0; i < 3; i++)
                Output();
            Console.Write("Повторить? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}
