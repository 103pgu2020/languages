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
                Console.WriteLine($"������: {mark} - �������");
                break;
            case 9:
            case 8:
                Console.WriteLine($"������: {mark} - ������");
                break;
            case 7:
            case 6:
                Console.WriteLine($"������: {mark} - �����������������");
                break;
            default:
                Console.WriteLine($"������: {mark} - �������");
                break;
        }

        Console.Write("\n���������? (1 - ��, 0 - ���) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}