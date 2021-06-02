using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, k = 0, i = 0;
        m1: Console.WriteLine("Введите натуральное число N: ");
            N = Convert.ToInt16(Console.ReadLine());
            if (N < 1)
            {
                Console.WriteLine("Введите число согласно условию");
                goto m1;
            }
            Console.WriteLine("Делители:");
            for (i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                    k++;
                }
            }
            Console.WriteLine("Кол-во делителей:" + k);
            Console.ReadKey();
        }
    }
}