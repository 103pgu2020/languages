using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
        m: double n = 1, k;
            Console.WriteLine("Введите km: ");
            k = Convert.ToDouble(Console.ReadLine());
            if (k < 1)
            {
                Console.WriteLine("Вы ввели неверное число");
                goto m;
            }
            Console.WriteLine("--------------");
            Console.WriteLine("мили      км");
            Console.WriteLine("--------------");
            for (double i = 1; i <= Math.Ceiling(k); i++)
            {
                if (i / 1.609344 < n) Console.WriteLine("{0,3:0.0000} {1,10:0.0000}", i / 1.609344, i);
                else
                {
                    if (n * 1.609344 <= k) Console.WriteLine("{0,3:0.0000} {1,10:0.0000}", n, n * 1.609344);
                    if (i <= k) Console.WriteLine("{0,3:0.0000} {1,10:0.0000}", i / 1.609344, i);
                    n++;
                }
            }
            Console.WriteLine("Повторить? 1-Да; Любое другое число-нет.");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto m;
            return;
        }
    }
}