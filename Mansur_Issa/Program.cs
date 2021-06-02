using System;
using System.Collections.Generic;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();

            int N = 0;
            while (N < 1 || N > 3999)
            {
                Console.WriteLine("Введите количество минут (натуральное число меньшее, чем 4000):");
                N = Int32.Parse(Console.ReadLine());
            }

            string arn = new string("IVXLCDM");
            string rN = "";
            int c = N;
            int i = 0;

            while (c != 0)
            {
                int t = c % 10;
                if (t != 0)
                {
                    string ed = new string(arn[i], (t % 5 - 1) % 3 + 1);
                    string d = new string(arn[i + (t + 1) / 5], (t + 2) / 6);
                    rN = ((t+1) % 5 == 0? ed + d : d + ed) + rN;
                }
                i += 2;
                c /= 10;
            }
            Console.WriteLine(rN);

            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}