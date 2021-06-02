using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, m;
        m1: 
            Console.WriteLine("Трёхзначные числа, в которых только две одинаковые цифры:");
            for (int i = 100; i < 1000; i++)
            {
                a = Math.Abs(i / 100);
                b = Math.Abs(i / 10 % 10);
                c = Math.Abs(i % 10);
                if ((a == b && a != c) || (b == c && c != a) || (a == c && a != b))
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
