﻿using System;

namespace Языки2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int b = 100;
            int count = 0;
            double k = 100;
            Console.WriteLine("Стартовый капитал = 100 рублей ");
        m: Console.WriteLine("Введите сумму, которую хотите получить: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            if (sum < b)
            {
                Console.WriteLine("Введите сумму больше стартового капитала");
                goto m;
            }
        m1: Console.WriteLine("Введите процент депозита ");
            double procent = Convert.ToDouble(Console.ReadLine());
            if (procent < 0)
            {
                Console.WriteLine("Введите процент больше нуля");
                goto m1;
            }
            while (k < sum)
            {
                k = (1 + procent / 100) * k;
                count++;
            }
            Console.WriteLine("Нужную сумму вы получите через: " + count + " месяц(а/ев)");
            Console.WriteLine("Повторить? 1-Да; Другое число-нет.");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto m;
            return;
        }
    }
}
