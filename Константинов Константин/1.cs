using System;

class Program
{
    static void Main()
    {
    n1: Console.Write("Число: ");
        long n = long.Parse(Console.ReadLine());
        int counter = 0;

        do
        {
            n /= 10;
            counter++;
        }
        while (n != 0);
        Console.WriteLine($"Количество цифр: {counter}");

        Console.Write("Повторить? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}