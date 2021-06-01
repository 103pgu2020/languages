using System;

class Program
{
    static void Main()
    {
    n1: int counter = 0;
        int prev = 0;

        while (true)
        {
            Console.Write("Число: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
                break;
            else
            {
                if (prev * num < 0 && prev != 0)
                    counter++;
                prev = num;
            }
        }
        Console.WriteLine($"Количество смен знаков: {counter}");

        Console.Write("Повторить? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}