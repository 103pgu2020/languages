using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислить количество цифр в данном числе");
       m1:  Console.Write("Введите число: ");
            int a, count = 0;
            a = Int32.Parse(Console.ReadLine());
            a = Math.Abs(a);
            while (a > 0)
            {
                a /= 10;
                count++;
            }
            Console.WriteLine("Количество цифр: " + count);
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            int u = Int32.Parse(Console.ReadLine());
            if (u == 1) goto m1;
            return;
        }
    }
}