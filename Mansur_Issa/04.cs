using System;
using System.Threading;

namespace _4
{
    class Program
    {
        static void Output(int hh, int mm, int ss)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.WindowHeight / 2 - 1);
            Console.WriteLine("{0:00}:{1:00}:{2:00}", hh, mm, ss);
        }
        static void Save(int hh, int mm, int ss, ref int k)
        {
            Console.SetCursorPosition(0, k);
            Console.WriteLine("{0:00}:{1:00}:{2:00}", hh, mm, ss);
            k++;
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Title = "Секундомер";

        main:
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth-12, 0);
            Console.WriteLine("Version 1.0");
            int hh = 0, mm = 0, ss = 0, k = 0;

            Output(hh, mm, ss);
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, Console.WindowHeight / 2);
            Console.WriteLine("Press SPACE for start");
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 11, Console.WindowHeight / 2+1);
                key = Console.ReadKey();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 11, Console.WindowHeight / 2+1);
                Console.Write(" ");
            }
            while (key.Key != ConsoleKey.Spacebar);

        start:
            Console.SetCursorPosition(Console.WindowWidth / 2 - 21, Console.WindowHeight / 2);
            Console.WriteLine("                                                     ");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2);
            Console.WriteLine("Press 1(stop) 2(save) 0(exit)");

            while (!Console.KeyAvailable)
            {
                System.Threading.Thread.Sleep(970);
                ss++;
                if (ss == 60)
                {
                    mm++;
                    ss = 0;
                }
                if (mm == 60)
                {
                    hh++;
                    mm = 0;
                }
                Output(hh, mm, ss);
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, Console.WindowHeight / 2 + 1);
            key = Console.ReadKey();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, Console.WindowHeight / 2 + 1);
            Console.Write(" ");
                
            
            if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                goto pause;
            if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                Save(hh,mm,ss-1,ref k);
            if (key.Key == ConsoleKey.D0 || key.Key == ConsoleKey.NumPad0)
                goto exit;
            goto start;

        pause:
            Console.SetCursorPosition(Console.WindowWidth / 2 - 21, Console.WindowHeight / 2);
            Console.WriteLine("                                                     ");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 21, Console.WindowHeight / 2);
            Console.WriteLine("Press 1(restart) 2(resume) 3(save) 0(exit)");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, Console.WindowHeight / 2 + 1);
            key = Console.ReadKey();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, Console.WindowHeight / 2 + 1);
            Console.Write(" ");
            if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                goto main;
            if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                goto start;
            if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
                Save(hh, mm, ss, ref k);
            if (key.Key == ConsoleKey.D0 || key.Key == ConsoleKey.NumPad0)
                goto exit;
            goto pause;

        exit:
            System.Threading.Thread.Sleep(1);
        }
    }
}
