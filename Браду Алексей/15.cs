using System;
namespace Program15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести на экран первые k членов ряда Фибоначчи. (1, 1, 2, 3, 5, 8...)");
        m1: Console.Write("Сколько нужно вывести членов последовательности Фибоначчи? N: ");
            int n, a = 0, b = 1, c = 0, k = 1;
            n = Int32.Parse(Console.ReadLine());
            if (n < 0) 
            {
                Console.WriteLine("Ошибка! Введите другое значение!"); 
                goto m1;
            }
            for(int i=1; i<=n;i++)
            {
                c = a + b;
                a = b;
                b = c;             
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            n = Int32.Parse(Console.ReadLine());
            if (n == 1) goto m1;
            return;
        }
    }
}