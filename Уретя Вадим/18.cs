using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*В лаборатории получают антибиотик.
            Начальное их количество в сосуде 2.
            Каждые 10 минут количество удваивается, каждые 30 минут половину антител забирают.
            Сколько антител будет в сосуде через N минут?*/
            Console.WriteLine("В лаборатории получают антибиотик. Начальное их количество в сосуде 2. Каждые 10 минут количество удваивается, каждые 30 минут половину антител забирают. Сколько антител в сосуде через N минут?");
        m1: Console.Write("\nВведите N = ");
            int k = 2, count = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            { 
                Console.WriteLine("Ошибка! Введите другое значение!");
                goto m1; 
            }
            while (n >= 10)
            {
                if (count == 3) 
                    count = 1;
                if (n >= 10)
                {
                    count++;
                    k *= 2;
                    if (count == 3) 
                        k /= 2;
                    n -= 10;
                }
            }
            Console.WriteLine("Осталось антител в сосуде= {0}", k);
            Console.WriteLine("\nЕще раз? Да - 1, нет - 0");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
                goto m1;
            return;
        }
    }
}
