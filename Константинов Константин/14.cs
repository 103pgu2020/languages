using System;

class Program
{
    static void Main()
    {
        n1:  Console.Write("����������� ����� n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("�������������� ����� x: ");
        double x = double.Parse(Console.ReadLine());
        double S = x;
        int m = n;
        bool sign = false;

        for (int i = 1; i <= n; i += 2)
        {
            if (sign)
                S += Math.Pow(x, i) / m;
            else
                S -= Math.Pow(x, i) / m;
            m = i * (i + 1) * (i + 2);
            sign = !sign;
        }
        Console.WriteLine(S);

        Console.Write("\n���������? (1 - ��, 0 - ���) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}