using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main()
        {
            for (int ryad = 1; ryad <= 8; ryad++)
            {
                for (int kletka = 1; kletka <= 8; kletka++)
                {
                    if (ryad % 2 == 0) Console.Write("* ");
                    else Console.Write(" *");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

        }
    }
}