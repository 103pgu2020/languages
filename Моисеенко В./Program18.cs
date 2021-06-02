using System;

namespace Языки18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для подсчёта кол-ва антабиотиков в сосуде через N минут?");
        m1: Console.Write("Введите N = ");
            int k = 2, count = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) { Console.WriteLine("Ошибка ввода, введите корректное значение"); goto m1; }
            while (n >= 10)
            {
                if (count == 3) count = 0;
                if (n >= 10)
                {
                    count++;
                    k *= 2;
                    if (count == 3) k /= 2;
                    n -= 10;
                }
            }
            Console.WriteLine("Осталось антител в сосуде= {0}", k);
            Console.WriteLine("Повторить? Да-1 ,Другое число - Нет");
            int l = Convert.ToInt16(Console.ReadLine());
            if (l == 1) goto m1;
            return;
        }
    }
}
