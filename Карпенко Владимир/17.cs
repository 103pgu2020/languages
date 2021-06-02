using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
        m:
            Random r = new Random();
            int k, ocenka = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = r.Next(1, 11), b = r.Next(1, 11);
                Console.Write("{0} * {1} = ", a, b);
                k = Int16.Parse(Console.ReadLine());
                if (k == a * b) ocenka++;
            }
            if (ocenka == 10) Console.WriteLine("Отлично");
            else if (ocenka == 9 || ocenka == 8) Console.WriteLine("Хорошо");
            else if (ocenka == 7 || ocenka == 6) Console.WriteLine("Удовлетворительно");
            else if (ocenka < 6) Console.WriteLine("Незачет");
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1) goto m;
            return;
        }
    }
}
