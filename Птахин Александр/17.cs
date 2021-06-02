using System;

namespace Program17
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: Console.WriteLine("Написать программу проверки знания таблицы умножения. Программа должна вывести 10 примеров и выставить оценку: за 10 правильных ответов - отлично, за 9 и 8 - хорошо, за 7 и 6 - удовлетворительно, за 6 и менее - незачет.");
            Random rnd = new Random();
            int k, count = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = rnd.Next(1, 11), b = rnd.Next(1, 11);
                Console.Write("{0} * {1} = ", a, b);
                k = Int16.Parse(Console.ReadLine());
                if (k == a * b) count++;
            }
            if (count == 10) Console.WriteLine("Отлично!");
            else
            if (count == 9 || count == 8) Console.WriteLine("Хорошо!");
            else
            if (count == 7 || count == 6) Console.WriteLine("Удовлетворительно!");
            else
            if (count < 6) Console.WriteLine("Незачет!");
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            k = Int32.Parse(Console.ReadLine());
            if (k == 1) goto m1;
            return;
        }
    }
}