using System;

namespace Языки16
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: Console.WriteLine("Программа, которая задумывает число в диапазоне от 1 до 1000 и предлагает пользователю угадать число за 10 попыток.");
            Random rnd = new Random();
            int a = rnd.Next(1, 1001), count = 10, b;
            do
            {
                Console.Write("Отгадайте число от 1 до 1000. Осталось попыток - {0}: ", count);
                b = Convert.ToInt32(Console.ReadLine());
                if (a == b) { Console.WriteLine("Вы угадали число!"); break; }
                count--;
                if (count > 0)
                {
                    if (b < a) Console.WriteLine("Заданное число больше!");
                    if (b > a) Console.WriteLine("Заданное число меньше!");
                }
                else Console.WriteLine("Попытки закончились!");
            }
            while (count != 0);
            Console.WriteLine("Повторить? Да-1 , Другое число - Нет");
            int k = Convert.ToInt16(Console.ReadLine());
            if (k == 1) goto m1;
            return;
        }
    }
}
