using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0, m;
            Console.WriteLine("Программа, выводящая все простые числа, <n.");
        m1: Console.WriteLine("Введите число n");
            n = Convert.ToInt16(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Введены неверные данные");
                goto m1;
            }
            Console.WriteLine("Простые числа:");
            for (int i = 1; i < n; i++)
            {
                k = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        k++;
                }
                if (k <= 2)
                {
                    Console.WriteLine(i);
                }
            }
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
