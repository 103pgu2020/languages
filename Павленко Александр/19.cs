using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, m;
            int[] a = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] b = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        m1: Console.WriteLine("Введите год (<4000)");
            n = Convert.ToInt32(Console.ReadLine());
            string str = "";
            i = 0;
            if (n < 1 || n > 3999)
            {
                Console.WriteLine("Введено неверное данные");
                goto m1;
            }
            while (n > 0)
            {
                if (a[i] <= n)
                {
                    n = n - a[i];
                    str = str + b[i];
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(str);
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
