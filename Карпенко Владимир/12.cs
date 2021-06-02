using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
           m: int N;
            Console.Write("N: ");
            N = Convert.ToInt32(Console.Read());
            if (N <= 0)
            {
                Console.WriteLine("Ошибка");
                goto m;
            }
           
            int i = 0;
            while (i++ <= N)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1) goto m;
        }
    }
}
