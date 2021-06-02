using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано натуральное число n и действительное x. Найти сумму ряда: S = x - x^3/3! + x^5/5! - x^7/7! + x^9/9! ... x^n/n!");
        m1: Console.WriteLine("Введите натуральное число n: ");
            double a = 0, count = 0, m;
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите действительное x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (n < 0 || x < 0)
            { 
                Console.WriteLine("Введены неверные значения"); 
                goto m1;
            }
            for (int i = 1; i <= n; i++)
            {
                count++;
                if (i % 2 == 0)
                {
                    count--;
                    continue;
                }
                int b = 1;
                for (int j = 1; j <= i; j++)
                {
                    b *= j;
                }
                if (count % 2 != 0)
                {
                    a += Math.Pow(x, i) / b;
                }
                else
                {
                    a -= Math.Pow(x, i) / b;
                }
            }
            Console.WriteLine("Сумма ряда = {0:0.00}", a);
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
