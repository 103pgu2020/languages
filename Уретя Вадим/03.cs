using System;


namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Пользователь вводит с клавиатуры последовательность чисел (пока не будет введён 0).
            Посчитать количество смен знаков в данной числовой последовательности.*/
            Console.WriteLine("Программа для подсчёта количества смен знака");
        m: Console.WriteLine("\nВведите попоследовательность, которая заканчивается вводом \"0\"");
            int count = 0, k = 1;
            double number = 0, cashe;
            do
            {
                Console.Write("Введите {0} член последовательности: ", k);
                cashe = number;
                k++;
                number = Convert.ToDouble(Console.ReadLine());
                if (Math.Sign(number) != Math.Sign(cashe))
                    count++;
            }
            while (number != 0);
            Console.WriteLine("Количество смен знака(ов) " + (count - 2));
            Console.WriteLine("\nПовторить? 1-Да; Любое другое число-нет.");
            k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
                goto m;
            return;

        }
    }
}
