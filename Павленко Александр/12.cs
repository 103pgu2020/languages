using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,count = 0, m;
            Console.WriteLine("Программа, выводящая на экран все делители натурального N и их количество.");
        m1: Console.WriteLine("Введите натуральное число N");
            N = Convert.ToInt32(Console.ReadLine());
            if (N < 1)
            {
                Console.WriteLine("N должно быть натуральным");
                goto m1;
            }
            Console.WriteLine("Делители:");
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine("Количество делителей: " + count);
            Console.WriteLine("Если хотите повторить программу введите '1'");
            m = Convert.ToInt32(Console.ReadLine());
            if (m == 1)
            {
                goto m1;
            }
            Console.ReadLine();
            return;
        }
    }
}
