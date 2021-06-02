using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();

            int N = 2;

            int m = -1;
            while (m < 0)
            {
                Console.WriteLine("Введите количество минут (неотрицательное число):");
                m = Int32.Parse(Console.ReadLine());
            }
            
            N *= (int)Math.Pow(2, m / 10 - m / 30);

            Console.WriteLine("Антител в сосуде через {0} минут(у)(ы): {1}", m, N);

            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}
