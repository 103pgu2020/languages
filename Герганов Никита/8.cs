using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано натуральное число N, вывести цифры в порядке убывания, не входящие в десятичную запись этого числа");
        m1: Console.Write("Введите N: ");
            int count = 0;
            int n = Int32.Parse(Console.ReadLine());
            int k = n;
            if (n < 0) { Console.WriteLine("Введите другое значение!"); goto m1; }
            while (n > 0)
            {
                n /= 10;
                count++;
            }
            int[] arr = new int[count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = k % 10;
                k /= 10;
            }
            for (int i = 9; i >= 0; i--)
            {
                count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != arr[j])
                        count++;
                    else
                    {
                        count = 0;
                        break;
                    }
                }
                if (count != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            int u = Int32.Parse(Console.ReadLine());
            if (u == 1) goto m1;
            return;
        }
    }
}