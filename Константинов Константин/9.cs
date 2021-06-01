using System;

class Program
{
    static void Main()
    {
        int num = 0;

        for (int i = 1; i <= 64; i++)
        {
            if (i % 2 == num)
                Console.Write("\U00002588\U00002588");
            else
                Console.Write("  ");

            if (i % 8 == 0)
            {
                num = (num == 1) ? 0 : 1;
                Console.WriteLine();
            }
        }
        Console.ReadKey();
    }
}