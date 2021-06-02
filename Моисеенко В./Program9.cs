using System;

namespace Языки9
{
    class Program
    {
        static void Main(string[] args)
        {
        m: Console.WriteLine("Программа для вывода на экран шахматной доски");
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
            Console.WriteLine("Повторить? 1-Да; Другое число-нет.");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto m;
            return;

        }
    }
}
