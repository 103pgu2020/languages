﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        m: Console.WriteLine("Программа, которая выводи на экран схему шахматной доски");
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    if ((i + k) % 2 == 0)
                        Console.Write((char)'\u2588');
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Повторить? 1-Да; Любое другое число-нет.");
            int l = Convert.ToInt32(Console.ReadLine());
            if (l == 1)
                goto m;
            return;
        }
    }
}