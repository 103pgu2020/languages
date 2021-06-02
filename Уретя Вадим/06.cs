using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Вывести все трёхзначные числа, сумма цифр которых меньше заданного N.*/
            Console.WriteLine("Вывести все трехзначные числа, сумма цифр которых меньше заданного N");
        m1: Console.Write("\nВведите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) 
            {
                Console.WriteLine("Введите другое значение!");
                goto m1;
            }
            for (int i = 100; i < 1000; i++)
                if (i / 100 + i % 100 / 10 + i % 10 < n)
                    Console.WriteLine(i);
            Console.WriteLine("\nЕще раз? Да - 1, нет - 0");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1) goto m1;
            return;
        }
    }
}
