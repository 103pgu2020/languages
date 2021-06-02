using System;

namespace Языки14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для нахождения суммы ряда");
        m1: Console.Write("Введи натуральное число n: ");
            double a = 0, count = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи действительное x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (n < 0 || x < 0) { Console.WriteLine("Ошибка ввода,введите корректное значение"); goto m1; }
            for (int i = 1; i <= n; i++)
            {
                count++;
                if (i % 2 == 0)
                {
                    count--;
                    continue;
                }
                int fk = 1;
                for (int j = 1; j <= i; j++)
                    fk *= j;
                if (count % 2 != 0)
                    a += Math.Pow(x, i) / fk;
                else
                    a -= Math.Pow(x, i) / fk;
            }
            Console.WriteLine("Сумма ряда = {0:0.00}", a);
            Console.WriteLine("Повторить ? Да-1 ,Другое число - нет.");
            int k = Convert.ToInt16(Console.ReadLine());
            if (k == 1) goto m1;
            return;
        }
    }
}
