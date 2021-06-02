using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();
            Console.WriteLine("Вводите последовательность:");
            int k = 0;
            double i, j = 0;
            while ((i = Double.Parse(Console.ReadLine()))!=0)
            {
                if (i * j < 0)
                    k++;
                j = i;
            }
            Console.WriteLine("Количество смен знаков: " + k);
            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            k = Int32.Parse(Console.ReadLine());
            if (k == 1)
                goto st;
        }
    }
}
