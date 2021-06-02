using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
       m1:  double S1 = 0, S2 = 0, S3 = 0;
            Console.WriteLine("Вывести 3 последовательности по 10 случайных чисел и их среднее арифметическое");
            int[] arr1 = new int[10];
            Random rand = new Random();
            Console.Write("Первая последовательность: ");
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rand.Next(-100, 101);
                Console.Write("{0} ", arr1[i]);
                S1 += arr1[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое: " + S1 / 10);
            Console.Write("Вторая последовательность: ");
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rand.Next(-100, 101);
                Console.Write("{0} ", arr1[i]);
                S2 += arr1[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое: " + S2 / 10);
            Console.Write("Третья последовательность: ");
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rand.Next(-100, 101);
                Console.Write("{0} ", arr1[i]);
                S3 += arr1[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое: " + S3 / 10);
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            int u = Int32.Parse(Console.ReadLine());
            if (u == 1) goto m1;
            return;
        }
    }
}