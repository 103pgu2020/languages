using System;


namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Вывести все трёхзначные числа, в которых только две одинаковые цифры.*/
            Console.WriteLine("Все трехзначные числа, в которых только две одинаковые цифры:");
            int a, b, c;
            for (int i = 100; i < 1000; i++)
            {
                a = i / 100;
                b = i / 10 % 10;
                c = i % 10;
                if ((a == b && a != c) || (b == c && b != a) || (a == c && a != b))
                    Console.WriteLine(i);
            }
            Console.ReadKey();
            return;
        }
    }
}
