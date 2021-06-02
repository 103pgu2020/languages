using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
        m:
            Console.Clear();
            Console.WriteLine("Введите N:");
            int N = Int32.Parse(Console.ReadLine());
            Console.WriteLine("цифры в порядке убывания, не входящие в десятичную запись этого числа:");
            for (int i = 9; i >= 0; i--)
            {
                int n = N;
                int a = 10;
                while (n != 0 && a != i)
                {
                    a = n % 10;
                    n = n / 10;
                }
                if (a != i)
                    Console.Write(i + "|");
            }
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto m;
        }
    }
}
