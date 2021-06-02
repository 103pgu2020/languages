using System;

namespace Языки8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа выводящая цифры в порядке убывания");
        m:
            Console.Clear();
            Console.WriteLine("Введите число:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Цифры, которые отсутствуют:");
            for (int i = 9; i >= 0; i--)
            {
                int n = N;
                int k = 10;
                while (n != 0 && k != i)
                {
                    k = n % 10;
                    n = n / 10;
                }
                if (k != i)
                    Console.Write(i + " ");
            }
            Console.WriteLine("\n Нажмите 1 для рестарта, Другие числа - Выход.");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto m;
        }
    }
}
