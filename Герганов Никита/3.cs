using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посчитать количество смен знака");
       m1:  Console.Write("Введите количество чисел: ");
            int count = 0;
            int n = Int32.Parse(Console.ReadLine());
            if (n < 0) { Console.WriteLine("Введите другое значение"); goto m1; }
            Console.WriteLine("Введите последовательность чисел");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
                if (arr[i] < 0 && arr[i + 1] >= 0 || arr[i] >= 0 && arr[i + 1] < 0)
                    count++;
            Console.WriteLine("Количество смен знака: " + count);
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            int u = Int32.Parse(Console.ReadLine());
            if (u == 1) goto m1;
            return;
        }
    }
}