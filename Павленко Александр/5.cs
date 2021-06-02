using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double k, s = 0, count = 0, p, m;
            Random a = new Random();
        m1: for (int j = 0; j < 3; j++)
            {
                s = 0;
                for (int i = 0; i < 10; i++)
                {
                    k = a.Next(-100, 100);
                    s += k;
                    Console.Write(k + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Среднее арифметическое {0} последовательности: {1} ",j + 1,  s / 10);
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
