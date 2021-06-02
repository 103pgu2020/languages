using System;
namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано натуральное число n и действительное x. Найти сумму ряда: S = x - x^3/3! + x^5/5! - x^7/7! + x^9/9! ... x^n/n!");
        m1: Console.Write("Введи натуральное число n: ");
            double a = 0, count = 0;
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Введи действительное x: ");
            int x = Int32.Parse(Console.ReadLine());
            if (n < 0 || x < 0) { Console.WriteLine("Ошибка! Введите другие значения!"); goto m1; }
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
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            int u = Int32.Parse(Console.ReadLine());
            if (u == 1) goto m1;
            return;
        }
    }
}