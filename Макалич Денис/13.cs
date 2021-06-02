using System;
namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0, i = 0, j = 0;
            Console.WriteLine("Программа нахождения простых чисел");
        m1: Console.WriteLine("Введите число n");
            n = Convert.ToInt16(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Ошибка ввода повторите ещё");
                goto m1;
            }
            Console.WriteLine("Простые числа:");
            for (i = 1; i < n; i++)
            {
                k = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        k++;
                }
                if (k <= 2) Console.WriteLine(i);
            }
            Console.WriteLine("Продолжить? (1 - да, другое число - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
            Console.ReadKey();
        }
    }
}