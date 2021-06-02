using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести на экран первые k членов ряда Фибоначчи. (1, 1, 2, 3, 5, 8...)");
        m1: Console.WriteLine("Введите k: ");
            int n, a = 0, b = 1, c = 0, d = 1, m;
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Введены неверные данные");
                goto m1; 
            }
            while (d <= n)
            {
                c = a + b;
                a = b;
                b = c;
                d++;
                Console.Write(a + " ");
            }
            Console.WriteLine();
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
