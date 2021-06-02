using System;

namespace Языки5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, sum1 = 0, sum2 = 0;
            double av;
            Random rand = new Random();
        m: Console.WriteLine("Программа для подсчёта среднего арифмитического трёх последовательностей");
            int[] mas1 = new int[10];
            int[] mas2 = new int[10];
            int[] mas3 = new int[10];
            Console.WriteLine("Первая последовательность: ");
            for (int i = 0; i < 10; i++)
            {
                mas1[i] = rand.Next(-100, 100);
                sum = sum + mas1[i];
                Console.WriteLine("mas1[{0}]={1}", i, mas1[i]);
            }
            Console.WriteLine("Вторая последовательность: ");
            for (int i = 0; i < 10; i++)
            {
                mas2[i] = rand.Next(-100, 100);
                sum1 = sum1 + mas1[i];
                Console.WriteLine("mas2[{0}]={1}", i, mas2[i]);
            }
            Console.WriteLine("Третья последовательность: ");
            for (int i = 0; i < 10; i++)
            {
                mas3[i] = rand.Next(-100, 100);
                sum2 = sum2 + mas1[i];
                Console.WriteLine("mas3[{0}]={1}", i, mas3[i]);
            }
            av = (sum + sum1 + sum2) / 3;
            Console.WriteLine("Среднее арифмитическое трёх последовательностей: " + av);
            Console.WriteLine("Повторить? 1-Да; Другое число-нет.");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto m;
            return;

        }
    }
}
