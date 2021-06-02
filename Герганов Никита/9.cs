using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести в шахматном порядке:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.Write("{0}", (char)'\u2588');
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            return;
        }
    }
}