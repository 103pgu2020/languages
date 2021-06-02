using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: double k = 0, s = 0, count = 0, m;
            Console.WriteLine("Введите последовательность чисел: ");
            for (int i = 0; i < 2; i++)
            {
                k = Convert.ToDouble(Console.ReadLine());
                if (k == 0)
                {
                    break;
                }
                if (s > 0 && k < 0 || s < 0 && k > 0)
                {
                    count++;
                }
                s = k;
                i = 0;
            }
            Console.WriteLine("Количество смен знаков в данной числовой последовательности: " + count);
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
