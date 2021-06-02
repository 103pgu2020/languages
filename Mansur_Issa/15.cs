using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();

            int k = 0;
            int f = 1, s = 0;
            while (k < 1)
            {
                Console.WriteLine("Введите натуральное число:");
                k = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Числа Фибоначчи ({0} штук):", k);
            for (int i=1; i<=k; i++)
            {
                f = (s+=f) - f;
                Console.Write(f + " ");
            }

            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}
