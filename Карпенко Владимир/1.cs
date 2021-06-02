using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вычисления количество цифр в данном числе");
        m: Console.Write("Введите число: ");
            int  count = 0;
            int x = Int32.Parse(Console.ReadLine());
            if (x == 0)
                count++;
            while (x != 0)
            {
                count++;
                x /= 10;
            }
            Console.WriteLine("Количество цифр: " + count);
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            int r = Int32.Parse(Console.ReadLine());
            if (r == 1) goto m;
            return;
        }
    }
}