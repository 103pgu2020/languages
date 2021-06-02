using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
          m:  int N, k = 0, i = 0;
            Console.WriteLine("Программа нахождения делителей");
        m1: Console.WriteLine("Введите натуральное число N");
            Console.Write("N: ");
            N = Convert.ToInt16(Console.ReadLine());
            if (N < 1)
            {
                Console.WriteLine("Ошибка ввода повторите ещё");
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
            Console.WriteLine("Колво делителей:" + k);
            Console.WriteLine("Повторить? 1-Да; Любое другое число-нет.");
          k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
                goto m;
            return;
        }
    }
}