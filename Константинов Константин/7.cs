using System;

class Program
{
    static void Main()
    {
        int a, b, c;

        for (int i = 100; i < 1000; i++)
        {
            a = i / 100;
            b = i / 10 % 10;
            c = i % 10;

            if (a == b && a != c || a == c && a != b || b == c && b != a)
                Console.WriteLine(i);
        }
    }
}