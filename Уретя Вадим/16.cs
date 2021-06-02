using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, которая "задумывает" число в диапазоне от 1 до 1000
            и предлагает пользователю угадать число за 10 попыток. После ввода ответа,
            программа выдаёт один из результатов: "Загаданное число меньше", "Загаданное число больше", "Угадал".*/
            Console.WriteLine("Программа которая задумывает число в диапазоне от 1 до 1000 и предлагает пользователю угадать число за 10 попыток. После ввода ответа, программа выдает один из результатов: Загаданное число меньше, загаданное число больше, угадал!");
        m1: Console.WriteLine("\nОтгадайте число от 1 до 1000: ");
            Random rnd = new Random();
            int a = rnd.Next(1, 1001), count = 10, b;
            do
            {
                Console.Write("Осталось попыток - {0}: ", count);
                b = Convert.ToInt32(Console.ReadLine());
                if (a == b)
                {
                    Console.WriteLine("Вы угадали число!"); 
                    break; 
                }
                count--;
                if (count > 0)
                {
                    if (b < a) Console.WriteLine("Заданное число больше!");
                    if (b > a) Console.WriteLine("Заданное число меньше!");
                }
                else Console.WriteLine("Попытки закончились!");
            }
            while (count != 0);
            Console.WriteLine("\nЕще раз? Да - 1, нет - 0");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto m1;
            return;
        }
    }
}
