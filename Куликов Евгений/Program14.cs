using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd14
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: Console.Write("Натуральное число n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
                Console.Write("Введите число согласно условию");
                goto m1;
            }
            Console.Write("Действительное число x: ");
            double x = double.Parse(Console.ReadLine());
            double S = x;
            int m = n;
            bool sign = false;
            for (int i = 1; i <= n; i += 2)
            {
                if (sign)
                    S += Math.Pow(x, i) / m;
                else
                    S -= Math.Pow(x, i) / m;
                m = i * (i + 1) * (i + 2);
                sign = !sign;
            }
            Console.WriteLine(S);
            Console.Write("\nЕщё раз? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}