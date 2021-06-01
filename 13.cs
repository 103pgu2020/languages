using System;

class Program
{
    static public bool IsSimple(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        n1:  Console.Write("Натуральное число N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            if (IsSimple(i))
                Console.Write($"{i} ");
        }

        Console.Write("\nПовторить? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}