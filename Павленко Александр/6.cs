using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c, m;
        m1: Console.WriteLine("Введите N: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Трёхзначные числа, сумма цифр которых меньше заданного N:");
            for (int i = 100; i < 1000; i++)
            {
                a = Math.Abs(i / 100);
                b = Math.Abs(i / 10 % 10);
                c = Math.Abs(i % 10);
                if ((a + b + c) < n)
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
