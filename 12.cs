using System;

class Program
{
    static void Main()
    {
        n1:  Console.Write("����������� ����� N: ");
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
        Console.WriteLine($"\n����� ���������� ���������: {counter}");

        Console.Write("\n���������? (1 - ��, 0 - ���) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}