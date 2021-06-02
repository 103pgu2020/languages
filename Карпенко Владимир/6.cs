using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
        m: Console.Write("Введите N: ");
            int N = Int32.Parse(Console.ReadLine());
            if (N < 0) 
            { 
                Console.WriteLine("Введите другое значение."); 
                goto m; 
            }
            for (int i = 100; i < 1000; i++)
                if (i / 100 + i % 100 / 10 + i % 10 < N)
                    Console.WriteLine(i);
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1) 
                goto m;
            return;
        }
    }
}