using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Программа для подсчёта количества смен знака");
        m: Console.WriteLine("Вв-те количество чисел последовательности");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Число не целое или меньше нуля. Повторите попытку.");
                goto m;
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Вв-те {0} член последовательности", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if ((arr[i] < 0 && arr[i + 1] >= 0) || (arr[i] >= 0 && arr[i + 1] < 0))
                    count++;
            }
            Console.WriteLine("Количество смен знака(ов) " + count);
            Console.WriteLine("Повторить? 1-Да; Любое другое число-нет.");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto m;
            return;

        }
    }
}