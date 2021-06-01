using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
    n1: int num = rand.Next(1, 1001);
        Console.WriteLine("Загадано число от 1 до 1000");
        int attempt;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i} попытка: ");
            attempt = int.Parse(Console.ReadLine());

            if (attempt > num)
                Console.WriteLine("Загаданное число меньше\n");
            else if (attempt < num)
                Console.WriteLine("Загаданное число больше\n");
            else
            {
                Console.WriteLine("Угадал");
                break;
            }
        }

        Console.Write("\nПовторить? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}