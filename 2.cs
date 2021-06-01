using System;

class Program
{
    static void Main()
    {
    n1: Console.Write("Стартовый капитал: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("На сколько процентов ежемесячно увеличивается: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Сумма для накопления: ");
        int S = int.Parse(Console.ReadLine());
        int months = 0;

        while (k <= S)
        {
            k += k / 100 * p;
            months++;
        }
        Console.WriteLine($"Сумма накопится через {months} месяцев");

        Console.Write("Повторить? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}