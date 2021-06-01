using System;

class Program
{
    static void Main()
    {
    n1: Console.Write("N: ");
        int N = int.Parse(Console.ReadLine());
        int a, b, c;

        for (int i = 100; i < 1000; i++)
        {
            a = i / 100;
            b = i / 10 % 10;
            c = i % 10;

            if ((a + b + c) < N)
                Console.WriteLine(i);
        }

        Console.Write("Повторить? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}