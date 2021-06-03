using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int n = 1; n <= 9; n++)
                {
                    Console.Write("{0}|", i * n);
                    if (n == 9)
                    { Console.WriteLine(); }

                }
            }

            Console.Read();
        }
    }
}