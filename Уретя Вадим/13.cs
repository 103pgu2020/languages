using System;


namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дано натуральное число n. Вывести все простые числа, <n.*/
            Console.WriteLine("Дано натуральное число n. Вывести все простые числа < n.");
        m1: Console.Write("\nВведите натуральное число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1)
            { 
                Console.WriteLine("Ошибка!"); 
                goto m1; 
            }
            Console.Write("Простые числа: ");
            for (int i = 2; i < n; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                    if (i % j == 0)
                        count++;
                if (count <= 2)
                    Console.Write(i + ", ");
            }
            Console.WriteLine("\n\nЕще раз? Да - 1, нет - 0");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
                goto m1;
            return;
        }
    }
}
