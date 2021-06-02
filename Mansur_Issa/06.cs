using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();
            Console.WriteLine("Введите N:");
            int N = Int16.Parse(Console.ReadLine());
            if (N<2)
                Console.WriteLine("Таких чисел нет!");
            else
            {
                Console.WriteLine("Подходящие числа:");
                for (int i = 100; i <= 999; i++)
                {
                    if (i%10 + i/100 + i%100/10<N)
                        Console.Write(i+ " ");
                }
            }
            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            N = Int32.Parse(Console.ReadLine());
            if (N == 1)
                goto st;
        }
    }
}
