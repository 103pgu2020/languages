using System;
namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
        m:
            Console.Clear();
            Console.WriteLine("Введите число:");
            int N = Int32.Parse(Console.ReadLine());
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
            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto m;
        }
    }
}