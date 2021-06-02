using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a, m;
        m1: for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("     |");
                }
                Console.WriteLine();
                for (int j = 1; j <= 10; j++)
                {
                    a = i * j;
                    Console.Write(" {0,3} |", a);
                }
                Console.WriteLine();
                for (int j = 1; j <= 60; j++)
                {
                    Console.Write("_");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Если хотите повторить программу введите '1'");
            m = Convert.ToInt32(Console.ReadLine());
            if (m == 1)
            {
                goto m1;
            }
            Console.ReadLine();
            return;
        }
    }
}
