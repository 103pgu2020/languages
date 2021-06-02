using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task20
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: double a = 1, km, m;
            Console.WriteLine("Введите km: ");
            km = Convert.ToDouble(Console.ReadLine());
            if (km < 1)
            {
                Console.WriteLine("Введены неверные данные");
                goto m1;
            }
            Console.WriteLine(" --------------------------");
            Console.WriteLine("| мили      |      км      |");
            Console.WriteLine(" --------------------------");
            for (double i = 1; i <= Math.Floor(km); i++)
            {
                if (i / 1.609344 < a)
                {
                    Console.WriteLine("| {0,3:0.0000}    | {1,10:0.0000}   |", i / 1.609344, i);
                    Console.WriteLine(" --------------------------");
                }
                else
                {
                    if (a * 1.609344 <= km)
                    {
                        Console.WriteLine("| {0,3:0.0000}    | {1,10:0.0000}   |", a, a * 1.609344);
                        Console.WriteLine(" --------------------------");
                    }
                    if (i <= km)
                    {
                        Console.WriteLine("| {0,3:0.0000}    | {1,10:0.0000}   |", i / 1.609344, i);
                        Console.WriteLine(" --------------------------");
                    }
                    a++;
                }
            }
            Console.WriteLine("Если хотите повторить программу введите '1'");
            m = Convert.ToInt32(Console.ReadLine());
            if (m == 1)
            {
                goto m1;
            }
            Console.ReadLine();
            return;
        }
    }
}
