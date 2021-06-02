using System;

namespace _13
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

            Console.WriteLine("Простые числа меньше заданного:");
            int k = 0;
            for (int i = 2; i < N; i++)
            {
                if ((i < 4 || (i+1)%6 == 0 || (i-1)%6 == 0) && (i == 5 || i%5!=0) && (i == 7 || i % 7 != 0))
                {
                    Console.Write(i + " ");
                    k++;
                }
            }
            if (k == 0)
                Console.WriteLine("Простые числа не найдены!");

            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}
