using System;
namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, k = 0, i = 0;
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
            Console.WriteLine("Продолжить? (1 - да, другое число - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
            Console.ReadKey();
        }
    }
}