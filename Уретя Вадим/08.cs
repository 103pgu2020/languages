using System;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дано натуральное N. Вывести цифры в порядке убывания, не входящие в десятичную запись этого числа.*/
            Console.WriteLine("Дано натуральное число N, вывести цифры в порядке убывания, не входящие в десятичную запись этого числа");
        m1: Console.Write("\nВведите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k;
            for (int i = 9; i >= 0; i--)
            {
                k = n;
                while (k != 0)
                {
                    if (k % 10 == i)
                        break;
                    k = k / 10;
                }
                if (k == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine("\n\nПовторить? 1-Да; Любое другое число-нет.");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1) 
                goto m1;
            return;
        }
    }
}
