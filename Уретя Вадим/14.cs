using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дано натуральное число n и действительное x. Найти сумму ряда S = x - x^3/3! + x^5/5! - x^7/7! + x^9/9! ... x^n/n!.*/
            Console.WriteLine("Дано натуральное число n и действительное x. Найти сумму ряда: S = x - x^3/3! + x^5/5! - x^7/7! + x^9/9! ... x^n/n!");
        m1: Console.Write("\nВведи натуральное число n: ");
            double a = 0, count = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи действительное x: ");
            double x = Convert.ToInt32(Console.ReadLine());
            if (n < 0) 
            {
                Console.WriteLine("Ошибка! Введите другие значения!");
                goto m1;
            }
            for (int i = 1; i <= n; i++)
            {
                count++;
                if (i % 2 == 0)
                {
                    count--;
                    continue;
                }
                int fact = 1;
                for (int j = 1; j <= i; j++)
                    fact *= j;
                if (count % 2 != 0)
                    a += Math.Pow(x, i) / fact;
                else
                    a -= Math.Pow(x, i) / fact;
            }
            Console.WriteLine("Сумма ряда = {0:0.00}", a);
            Console.WriteLine("\nЕще раз? Да - 1, нет - 0");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
                goto m1;
            return;
        }
    }
}
