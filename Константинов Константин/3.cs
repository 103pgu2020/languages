using System;

class Program
{
    static void Main()
    {
    n1: int counter = 0;
        int prev = 0;

        while (true)
        {
            Console.Write("�����: ");
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
        Console.WriteLine($"���������� ���� ������: {counter}");

        Console.Write("���������? (1 - ��, 0 - ���) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}