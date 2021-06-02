using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 i, k;
        m: Console.WriteLine("Программа, которая выводи на экран схему шахматной доски");
            for ( i = 0; i < 8; i++)
            {
                for ( k = 0; k < 8; k++)
                {
                    if ((i + k) % 2 == 0)
                        Console.Write((char)'\u2588');
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Повторить? 1-Да; Любое другое число-нет.");
            i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
                goto m;
            return;
        }
    }
}