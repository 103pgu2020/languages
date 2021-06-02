using System;


namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Вывести три последовательности по 10 случайных чисел и среднее арифметическое каждой последовательности.*/
        m1: double a;
            Console.WriteLine("\nВывести 3 последовательности по 10 случайных чисел и их среднее арифметическое");
            int[] arr1 = new int[10];
            Random rand = new Random();
            for (int j = 0; j < 3; j++)
            {
                a = 0;
                Console.Write("{0} последовательность: ", j + 1);
                for (int i = 0; i < 10; i++)
                {
                    arr1[i] = rand.Next(-100, 101);
                    Console.Write("{0} ", arr1[i]);
                    a += arr1[i];
                }
                Console.WriteLine();
                Console.WriteLine("Среднее арифметическое: " + a / 10);
            }
            Console.WriteLine("\nЕще раз? Да - 1, нет - 0");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1) goto m1;
            return;
        }
    }
}
