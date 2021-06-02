using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: Console.WriteLine("Написать программу проверки знания таблицы умножения.");
            Random r = new Random();
            int n, a, b, count = 0, m;
            for (int i = 0; i < 10; i++)
            {
                a = r.Next(1, 11);
                b = r.Next(1, 11);
                Console.Write("{0} * {1} = ", a, b);
                n = Convert.ToInt32(Console.ReadLine());
                if (n == a * b)
                {
                    count++;
                }
            }
            if (count == 10)
            {
                Console.WriteLine("Отлично");
            }
            else if (count == 9 || count == 8)
            {
                Console.WriteLine("Хорошо");
            }
            else if (count == 7 || count == 6)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else  
            {
                Console.WriteLine("Незачет");
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
