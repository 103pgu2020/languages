using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Коммерсант, имея стартовый капитал k рублей, который ежемесячно увеличивается на p%.
        Через сколько месяцев он накопит сумму S?*/
        m1: Console.Write("\nВведите свой стартовый капитал: ");
            int count = 0;
            double k = Convert.ToDouble(Console.ReadLine());
            if (k <= 0)
            {
                Console.WriteLine("Стартовы капитал должен быть больше 0");
                goto m1;
            }
        m2: Console.Write("Введите процент, на который капитал увеличивается каждый месяц: ");
            double p = Convert.ToDouble(Console.ReadLine());
            if (p <= 0)
            {
                Console.WriteLine("Капитал не может увеличиваться, если процент не больше о");
                goto m2;
            }
        m3: Console.Write("Введите сумму, что он должен накопить: ");
            double s = Convert.ToDouble(Console.ReadLine());
            if (s <= k)
            {
                Console.WriteLine("Накопленная сумма должна быть больше стартового капитала");
                goto m3;
            }
            while (k < s)
            {
                k = (1 + p / 100) * k;
                count++;
            }
            Console.WriteLine("Нужную сумму вы получите через " + count + " месяц(а/ев)");
            Console.WriteLine("\nПовторить? 1-Да; Любое другое число-нет.");
            k = Convert.ToInt32(Console.ReadLine());
            if (k == 1)
                goto m1;
            return;
        }
    }
}
