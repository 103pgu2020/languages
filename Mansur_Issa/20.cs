using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();

            double N = 0;
            while (N < 1 )
            {
                Console.WriteLine("Введите порог расстояния в км (>0):");
                N = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Мили    |Км");
            Console.WriteLine(new String('-', 8) + "+" + new String('-', 8));

            double km = 1.609344;
            double s = km;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("{0, 8:0.0000}|{1, 8:0.0000}" , i / km, i);
                if (s - i < 1 && s - i > 0 && s <= N)
                {
                    Console.WriteLine("{0, 8:0.0000}|{1, 8:0.0000}", s / km, s);
                    s += km;
                }
            }

            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}
