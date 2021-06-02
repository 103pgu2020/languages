using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j=0; j < 4; j++)
                {
                    if (i % 2 == 0)
                    {
                    Console.Write(" ");
                    Console.Write("*");
                    }
                    else
                    {
                        Console.Write("*");
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
