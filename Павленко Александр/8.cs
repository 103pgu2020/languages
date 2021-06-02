using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
           m1: Console.WriteLine("Введите натуральное N: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Цифры, не входящие в десятичную запись этого числа:");
            for (int i = 9; i >= 0; i--)
            {
                int N = n;
                int a = 10;
                while (N != 0 && a != i)
                {
                    a = N % 10;
                    N = N / 10;
                }
                if (a != i)
                    Console.Write(i + " ");
            }
            Console.WriteLine("");
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
