using System;

class Program
{
    static void Main()
    {
    n1: Console.Write("�����: ");
        long n = long.Parse(Console.ReadLine());
        int counter = 0;

        do
        {
            n /= 10;
            counter++;
        }
        while (n != 0);
        Console.WriteLine($"���������� ����: {counter}");

        Console.Write("���������? (1 - ��, 0 - ���) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}