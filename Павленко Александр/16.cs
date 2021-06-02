using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task16
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: Console.WriteLine("Написать программу которая задумывает число в диапазоне от 1 до 1000 и предлагает пользователю угадать число за 10 попыток.");
            Random r = new Random();
            int a, count = 10, b, m;
            a = r.Next(1, 1001);
            do
            {
                Console.WriteLine("Отгадайте число от 1 до 1000. Осталось попыток - {0}: ", count);
                b = Convert.ToInt32(Console.ReadLine());
                if (a == b)
                { 
                    Console.WriteLine("Угадал");
                    break; 
                }
                count--;
                if (count > 0)
                {
                    if (b < a) Console.WriteLine("Заданное число больше");
                    if (b > a) Console.WriteLine("Заданное число меньше");
                }
                else
                {
                    Console.WriteLine("Попытки закончились");
                }
            }
            while (count != 0);
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
