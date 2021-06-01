using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
    n1: int a, b, c;
        int mark = 0;

        for (int i = 0; i < 10; i++)
        {
            a = rand.Next(1, 10);
            b = rand.Next(1, 10);

            Console.Write($"{a} * {b} = ");
            c = int.Parse(Console.ReadLine());

            if (c == a * b)
                mark++;
        }

        switch (mark)
        {
            case 10:
                Console.WriteLine($"Оценка: {mark} - Отлично");
                break;
            case 9:
            case 8:
                Console.WriteLine($"Оценка: {mark} - Хорошо");
                break;
            case 7:
            case 6:
                Console.WriteLine($"Оценка: {mark} - Удовлетворительно");
                break;
            default:
                Console.WriteLine($"Оценка: {mark} - Незачёт");
                break;
        }

        Console.Write("\nПовторить? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}