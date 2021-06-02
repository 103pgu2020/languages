using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
        m: double sra1 = 0, sra2 = 0, sra3 = 0;
            int[] arr1 = new int[10];
            Random rand = new Random();
            Console.Write("Первая последовательность: ");
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rand.Next(-59, 60);
                Console.Write("{0} ", arr1[i]);
                sra1 += arr1[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое: " + sra1 / 10);
            Console.Write("Вторая последовательность: ");
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rand.Next(-59, 60);
                Console.Write("{0} ", arr1[i]);
                sra2 += arr1[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое: " + sra2 / 10);
            Console.Write("Третья последовательность: ");
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rand.Next(-59, 60);
                Console.Write("{0} ", arr1[i]);
                sra3 += arr1[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое: " + sra3 / 10);
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1) goto m;
            return;
        }
    }
}