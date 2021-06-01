using System;

class Program
{
    static void Main()
    {
    n1: Console.Write("k: ");
        int k = int.Parse(Console.ReadLine());
        int a = 1;
        int b = 1;
        int c;
        Console.Write($"{a} {b} ");

        for (int i = 0; i < k - 2; i++)
        {
            c = a + b;
            a = b;
            b = c;
            Console.Write($"{c} ");
        }

        Console.Write("\n\nПовторить? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}