using System;
namespace Program18
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 2, count = 0;
            Console.WriteLine("В лаборатории получают антибиотик. Начальное их количество в сосуде 2. Каждые 10 минут количество удваивается, каждые 30 минут половину антител забирают. Сколько антител в сосуде через N минут?");
        m1: Console.Write("Введите N = ");
           
            int n = Int32.Parse(Console.ReadLine());
            if (n < 0) { Console.WriteLine("Ошибка! Введите другое значение!"); goto m1; }
            while (n >= 10)
            {
                if (count == 3) count = 0;
                if (n >= 10)
                {
                    count++;
                    k *= 2;
                    if (count == 3) k /= 2;
                    n -= 10;
                }
            }
            Console.WriteLine("Осталось антител в сосуде= {0}", k);
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            n = Int32.Parse(Console.ReadLine());
            if (n == 1) goto m1;
            return;
        }
    }
}