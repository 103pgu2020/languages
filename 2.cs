using System;

class Program
{
    static void Main()
    {
    n1: Console.Write("��������� �������: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("�� ������� ��������� ���������� �������������: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("����� ��� ����������: ");
        int S = int.Parse(Console.ReadLine());
        int months = 0;

        while (k <= S)
        {
            k += k / 100 * p;
            months++;
        }
        Console.WriteLine($"����� ��������� ����� {months} �������");

        Console.Write("���������? (1 - ��, 0 - ���) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}