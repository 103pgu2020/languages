using System;

namespace Языки4
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("Программа для подсчёта количества смен знака");
        m: Console.WriteLine("Введите количество чисел последовательности");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Число не целое или меньше нуля.");
                goto m;
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0} член последовательности", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if ((arr[i] < 0 && arr[i + 1] >= 0) || (arr[i] >= 0 && arr[i + 1] < 0))
                    c++;
            }
            Console.WriteLine("Количество смен знака(ов) " + c);
            Console.WriteLine("Повторить? 1-Да; Другое число-нет.");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto m;
            return;

        }
    }
}
