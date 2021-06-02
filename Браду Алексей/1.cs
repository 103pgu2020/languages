using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
        m: Console.WriteLine("Введите целое число: ");
            double k = Convert.ToDouble(Console.ReadLine());
            if (k != Math.Truncate(k))
            {
                Console.WriteLine("Число не целое");
                goto m;
            }
            k = Math.Abs(k);
            count = (int)Math.Log10(k) + 1;
            Console.WriteLine("Количество цифр в данном числе " + count);
            Console.WriteLine("Повторить? 1-Да; Любое другое число-нет.");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto m;
            return;

        }
    }
}