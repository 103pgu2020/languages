using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();

            int N = 0;
            while (N < 1)
            {
                Console.WriteLine("Введите натуральное число:");
                N = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Делители:");
            int k = 0;
            for (int i = 1; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    Console.Write(i + " ");
                    k++;
                }
            }
            Console.Write(N);
            k++;
            Console.WriteLine("\nКоличество делителей: " + k);
            
            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}
