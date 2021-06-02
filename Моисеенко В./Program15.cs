using System;

namespace Языки15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вывода первых k членов Фибоначчи");
        m1: Console.Write("Введите количесво чисел Фибоначчи N: ");
            int n, a = 0, b = 1, s = 0, k = 1;
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) { Console.WriteLine("Ошибка ввода, введите корректное значение"); goto m1; }
            while (k <= n)
            {
                s = a + b;
                a = b;
                b = s;
                k++;
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Повторить? Да-1 ,Другое число - Нет");
            int l = Convert.ToInt32(Console.ReadLine());
            if (l == 1) goto m1;
            return;
        }
    }
}
