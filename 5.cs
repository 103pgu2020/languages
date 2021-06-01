using System;

class Program
{
    static Random rand = new Random();

    static void Output()
    {
        double mean = 0;
        Console.Write("Последовательность: ");
        for (int i = 0; i < 10; i++)
        {
            int num = rand.Next(-100, 100);
            Console.Write($"{num} ");
            mean += num;
        }
        mean /= 10;
        Console.WriteLine($"\nСреднее арифметическое: {mean}\n");
    }

    static void Main()
    {
        for (int i = 0; i < 3; i++)
            Output();
    }
}