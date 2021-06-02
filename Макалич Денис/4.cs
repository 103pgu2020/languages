using System;
using System.Threading;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, s = 0, ms = 0, i = 1;
            ConsoleKeyInfo key;
            Console.WriteLine("  Saves:");
        point:
            Console.Write("\b ");
            Console.SetCursorPosition(32, 10);
            Console.WriteLine("{0:00}:{1:00}:{2:00}", m, s, ms);
            Console.SetCursorPosition(27, 13);
            Console.WriteLine("Press any key to start.");
            Console.ReadKey();
        point_2:
            Console.Write("\b ");
            Console.SetCursorPosition(27, 13);
            Console.WriteLine("Press any key to stop.  ");
            Console.WriteLine(" ");

            while (!Console.KeyAvailable)
            {
                ms++;
                Thread.Sleep(15);
                if (ms == 100) { s++; ms = 0; Console.SetCursorPosition(35, 10); Console.WriteLine("{0:00}", s); }
                if (s == 60) { m++; s = 0; Console.SetCursorPosition(32, 10); Console.WriteLine("{0:00}:{1:00}", m, s); }
                Console.SetCursorPosition(38, 10);
                Console.WriteLine("{0:00}", ms);
            }
            Console.Write("\b ");
            Console.SetCursorPosition(25, 14);
            Console.WriteLine(" ");
            Console.SetCursorPosition(27, 13);
            Console.WriteLine("Press: 1 - to return   ");
            Console.SetCursorPosition(34, 14);
            Console.WriteLine("2 - to reset");
            Console.SetCursorPosition(34, 15);
            Console.WriteLine("3 - to save");
            Console.SetCursorPosition(34, 16);
            Console.WriteLine("0 - to end");
            Console.ReadKey();
            Console.Write("\b ");
        m:
            Console.Write("\b ");
            key = Console.ReadKey();
            Console.Write("\b ");
            if (key.KeyChar == '2')
            {
                m = 0; s = 0; ms = 0;
                Console.SetCursorPosition(27, 13);
                Console.WriteLine("                         ");
                Console.SetCursorPosition(34, 14);
                Console.WriteLine("             ");
                Console.SetCursorPosition(34, 15);
                Console.WriteLine("             ");
                Console.SetCursorPosition(34, 16);
                Console.WriteLine("             ");
                goto point;
            }
            if (key.KeyChar == '1')
            {
                Console.SetCursorPosition(27, 13);
                Console.WriteLine("                         ");
                Console.SetCursorPosition(34, 14);
                Console.WriteLine("             ");
                Console.SetCursorPosition(34, 15);
                Console.WriteLine("             ");
                Console.SetCursorPosition(34, 16);
                Console.WriteLine("             ");
                goto point_2;
            }
            if (key.KeyChar == '3')
            {

                Console.SetCursorPosition(0, i);
                Console.WriteLine("{0}: {1:00}:{2:00}:{3:00}", i, m, s, ms);
                i++;
                goto m;
            }
        }
    }
}