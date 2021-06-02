using System;

namespace Языки12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, k = 0, i = 0;
            Console.WriteLine("Программа нахождения делителей числа N");
        m1: Console.WriteLine("Введите натуральное число N");
            Console.Write("N=  ");
            N = Convert.ToInt16(Console.ReadLine());
            if (N < 1)
            {
                Console.WriteLine("Ошибка ввода,введите корректное значение");
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
