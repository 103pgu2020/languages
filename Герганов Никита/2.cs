using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Компания имеет стартовый капитал k руб, который ежемесячно увеличивается на p %. Через сколько месяцев он окупит сумму S?");
        m1: Console.Write("Стартовый капитал: ");
            int k, p, s, count = 0;
            k = Int32.Parse(Console.ReadLine());
            Console.Write("Ежемесячное увеличение: ");
            p = Int32.Parse(Console.ReadLine());
            Console.Write("Сумма: ");
            s = Int32.Parse(Console.ReadLine());
            if (k < 0 || p < 0 || s < 0) { Console.WriteLine("Введите другое значение!"); goto m1; }
            while (k < s)
            {
                k = (k * p / 100) + k;
                count++;
            }
            Console.WriteLine("Через {0} мес.", count);
            Console.WriteLine("Еще раз? Да - 1, нет - 0");
            int u = Int32.Parse(Console.ReadLine());
            if (u == 1) goto m1;
            return;
        }
    }
}