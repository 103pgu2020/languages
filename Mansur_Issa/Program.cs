using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
        //st:
            Console.Clear();

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                    if (i+j == 0)
                        Console.Write("    ");
                    else if (i*j == 0)
                        Console.Write("{0,4}", i+j);
                    else
                        Console.Write("{0,4}", i*j);
                Console.WriteLine('\n');
            }

            Console.SetCursorPosition(0, 1);
            Console.Write(new String('-', 44));
            for (int i = 0; i < 21; i++)
            {
                Console.SetCursorPosition(5, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(5, 1);
            Console.Write("+");
            Console.SetCursorPosition(0, 21);
            /*
            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
            */
        }
    }
}
