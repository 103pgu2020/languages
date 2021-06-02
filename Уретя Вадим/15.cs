using System;


namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Вывести на экран первые k членов ряда Фибоначчи (1, 1, 2, 3, 5, 8).*/
            Console.WriteLine("Вывести на экран первые k членов ряда Фибоначчи. (1, 1, 2, 3, 5, 8...)");
        m1: Console.Write("\nСколько нужно вывести членов последовательности Фибоначчи? k: ");
            int a = 0, b = 1, s, k = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            { 
                Console.WriteLine("Ошибка! Введите другое значение!"); 
                goto m1;
            }
            while (k <= n)
            {
                s = a + b;
                a = b;
                b = s;
                k++;
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nЕще раз? Да - 1, нет - 0");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1) goto m1;
            return;
        }
    }
}
