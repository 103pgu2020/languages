using System;
using System.Threading;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            string time;
            int znach = 0, k = 3, Seconds = 0, Minutes = 0, Milliseconds = 0;
            bool c = false;
        m1: Console.Clear();
            Console.SetCursorPosition(30, 13);
            Console.WriteLine("Press space to start!");
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Black;
            object a = Console.ReadLine();
            Console.ResetColor();
            if (a.Equals(" ")) znach = 3;
            else Console.WriteLine("Ошибка! Вы ввели неверное значение!");
            Console.Clear();
        m2: switch (znach)
            {
                case 0:
                    break;

                case 1:
                case 2:
                case 3:
                    Console.SetCursorPosition(30, 13);
                    Console.WriteLine("Press: 0 to exit");
                    Console.SetCursorPosition(30, 14);
                    Console.WriteLine("       1 to restart");
                    Console.SetCursorPosition(30, 15);
                    Console.WriteLine("       2 to save");
                    while (!Console.KeyAvailable)
                    {
                        if (znach == 1)
                        {
                            Milliseconds = 0; Seconds = 0; Minutes = 0;
                            c = true;
                            goto m1;
                        }
                        if (znach == 2)
                        {
                            if (c)
                            {
                                Console.SetCursorPosition(0, 3);
                                k = 3;
                                c = false;
                            }
                            Console.SetCursorPosition(0, k);
                            Console.Write("{0:00}:{1:00}:{2:00}", Minutes, Seconds, Milliseconds);
                            k++;
                            znach = 3;
                        }
                        if (znach == 1) { Milliseconds = 0; Seconds = 0; Minutes = 0; }
                        time = String.Format("{0:00}:{1:00}:{2:00}", Minutes, Seconds, Milliseconds);
                        Milliseconds += 1;
                        if (Milliseconds == 100) { Milliseconds = 0; Seconds += 1; }
                        if (Seconds == 60) { Seconds = 0; Minutes += 1; }
                        if (Minutes == 60) Minutes = 0;
                        Console.SetCursorPosition(35, 11);
                        Console.Write(time);
                        Thread.Sleep(10);
                        Console.SetCursorPosition(0, 1);
                    }
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Black;
                    znach = Int32.Parse(Console.ReadLine());
                    Console.ResetColor();
                    if (znach == 0 || znach == 1 || znach == 2 || znach == 3) goto m2;
                    else Console.WriteLine("Ошибка! Вы ввели неверное значение!");
                    break;

                default:
                    Console.WriteLine("Ошибка! Вы ввели неверное значение!");
                    break;
            }
            return;
        }
    }
}