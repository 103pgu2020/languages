using System;


namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Вывести на экран все делители натурального N и их количество.*/
            Console.WriteLine("Вывести на экран все делители натурального N и их количество.");
        m1: Console.Write("\nВведите натуральное число N: ");
            int count = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1)
            { 
                Console.WriteLine("Ошибка!"); 
                goto m1; 
            }
            Console.WriteLine("Делители:");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine("Количество делителей: " + count);
            Console.WriteLine("\nЕще раз? Да - 1, нет - 0");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
                goto m1;
            return;
        }
    }
}
