using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Карасев_Иван_20
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: double n = 1, k;
            Console.WriteLine("Введите km: ");
            k = Convert.ToDouble(Console.ReadLine());
            if (k < 1)
            {
                Console.WriteLine("Вдённое число не соответсвует условию");
                goto m1;
            }
            Console.WriteLine("--------------");
            Console.WriteLine("мили      км");
            Console.WriteLine("--------------");
            for (double i = 1; i <= Math.Ceiling(k); i++)
            {
                if (i / 1.609344 < n) Console.WriteLine("{0,3:0.0000} {1,10:0.0000}", i / 1.609344, i);
                else
                {
                    if (n * 1.609344 <= k) Console.WriteLine("{0,3:0.0000} {1,10:0.0000}", n, n * 1.609344);
                    if (i <= k) Console.WriteLine("{0,3:0.0000} {1,10:0.0000}", i / 1.609344, i);
                    n++;
                }
            }
            Console.Write("\nЕщё раз? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}