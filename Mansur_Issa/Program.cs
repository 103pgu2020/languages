using System;

namespace _14
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
            Console.WriteLine("Введите действительное число:");
            double x = Double.Parse(Console.ReadLine());

            double S = 0;
            for (int i=1; i<=N; i+=2)
            {
                int f = 1;
                for (int j = 2; j <= i; j++)
                    f *= j;
                if ((i + 1) % 4 == 2)
                    S += Math.Pow(x,i) / f;
                else
                    S -= Math.Pow(x, i) / f;
            }
            Console.WriteLine("Сумма ряда: " + S);

            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int p = Int32.Parse(Console.ReadLine());
            if (p == 1)
                goto st;
        }
    }
}
