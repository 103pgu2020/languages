using System;

class Program
{
    static void Main()
    {
        n1:  Console.Write("Натуральное число N: ");
        int N = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 1; i <= N / 2; i++)
        {
            if (N % i == 0)
            {
                Console.Write("{0} ", i);
                counter++;
            }
        }
        Console.WriteLine($"\nОбщее количество делителей: {counter}");

        Console.Write("\nПовторить? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}