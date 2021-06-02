using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        m: double sum0 = 0, sum1 = 0, sum2 = 0;
            Random rand = new Random();
       Console.WriteLine("Программа для подсчёта среднего арифмитического трёх последовательностей");
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            Console.WriteLine("Первая последовательность");
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = rand.Next(-100, 100);
                sum0 = sum0 + arr1[i];
                Console.WriteLine("arr1[{0}]={1}", i, arr1[i]);
            }
            Console.WriteLine("Вторая последовательность");
            for (int i = 0; i < 10; i++)
            {
                arr2[i] = rand.Next(-100, 100);
                sum1 = sum1 + arr2[i];
                Console.WriteLine("arr2[{0}]={1}", i, arr2[i]);
            }
            Console.WriteLine("Третья последовательность");
            for (int i = 0; i < 10; i++)
            {
                arr3[i] = rand.Next(-100, 100);
                sum2 = sum2 + arr3[i];
                Console.WriteLine("arr3[{0}]={1}", i, arr3[i]);
            }
            sum0 = sum0 / 10;
            sum1 = sum1 / 10;
            sum2 = sum2 / 10;
            Console.WriteLine("Среднее арифмитическое первой последовательности: " + sum0);
            Console.WriteLine("Среднее арифмитическое второй последовательности: " + sum1);
            Console.WriteLine("Среднее арифмитическое третьей последовательности: " + sum2);
            Console.WriteLine("Повторить? 1-Да; Любое другое число-нет.");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                goto m;
            return;
        }
    }
}