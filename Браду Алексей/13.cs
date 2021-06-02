using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0, i = 0, j = 0;
            Console.WriteLine("Программа нахождения простых чисел");
        m1: Console.WriteLine("Введите число n");
            Console.Write("n: ");
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
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            n = Int32.Parse(Console.ReadLine());
            if (n == 1) goto m1;
            return;
        }
    }
}