using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();
            Console.WriteLine("Введите N:");
            int N = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Искомые цифры:");
            for (int i = 9; i >= 0; i--)
            {
                int n = N;
                int p = 10;
                while (n != 0 && p != i)
                {
                    p = n % 10;
                    n = n / 10;
                }
                if (p != i)
                    Console.Write(i + " ");
            }
            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}
