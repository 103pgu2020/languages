using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n, m;
        m1: Console.WriteLine("Введите целое число");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                count++;
            }
            else
            {
                while (Math.Abs(n) > 0)
                {
                    count++;
                    n = (int)(n / 10);
                }
            }
            Console.WriteLine("Количество цифр в числе: " + count);
            count = 0;
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
