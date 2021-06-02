using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();
            Console.WriteLine("Подходящие числа:");
            for (int i = 100; i <= 999; i++)
            {
                int s = i / 100;
                int d = i / 10 % 10;
                int e = i % 10;
                if ((s==d || d==e || s==e) && i % 111 != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}