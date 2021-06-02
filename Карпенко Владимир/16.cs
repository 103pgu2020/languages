using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
        m:
            Random r = new Random();
            int x = r.Next(1, 1001), count = 10, y;
            do
            {
                Console.Write("Отгадайте число от 1 до 1000. Попыток - {0}: ", count);
                y = Int32.Parse(Console.ReadLine());
                if (x == y) { Console.WriteLine("Поздравляем Вы угадали число."); break; }
                count--;
                if (count > 0)
                {
                    if (y < x) Console.WriteLine("Заданное число больше.");
                    if (y > x) Console.WriteLine("Заданное число меньше.");
                }
                else Console.WriteLine("Попытки закончились.");
            }
            while (count != 0);
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t == 1) goto m;
            return;
        }
    }
}
