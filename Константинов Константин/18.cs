using System;

class Program
{
    static void Main()
    {
    n1: Console.Write("N: ");
        int N = int.Parse(Console.ReadLine());
        int count = 2;

        for (int i = 1; i <= N / 10; i++)
        {
            if (i % 3 != 0)
                count *= 2;
        }
        Console.WriteLine(count);

        Console.Write("\nПовторить? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}