using System;

namespace _Языки10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа воводащая на экран квадрат Пифагора - таблицу умножения");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0,3} ", i * j);
                    if (j == 10)
                        Console.WriteLine();
                }
            }
            Console.ReadKey();
            return;
        }
    }
}
