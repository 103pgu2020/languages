using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
    n1: int num = rand.Next(1, 1001);
        Console.WriteLine("�������� ����� �� 1 �� 1000");
        int attempt;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i} �������: ");
            attempt = int.Parse(Console.ReadLine());

            if (attempt > num)
                Console.WriteLine("���������� ����� ������\n");
            else if (attempt < num)
                Console.WriteLine("���������� ����� ������\n");
            else
            {
                Console.WriteLine("������");
                break;
            }
        }

        Console.Write("\n���������? (1 - ��, 0 - ���) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}