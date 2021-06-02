using System;

namespace Языки6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Программа выводящая трёхназчные числа, сумма цифр которых меньше заданного n");
        m: Console.WriteLine("Введите n");
            double n = Convert.ToDouble(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Введите положительное n");
                goto m;
            }
            for (int i = 100; i < 1000; i++)
            {
                a = i / 100;
                b = i / 10 % 10;
                c = i % 10;
                if ((a + b + c) < n)
                    Console.WriteLine(i);
            }
            Console.WriteLine("Повторить? 1-Да; Другое число-нет.");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
                goto m;
            return;
        }
    }
}
