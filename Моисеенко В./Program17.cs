using System;

namespace Языки17
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: Console.WriteLine("Программа для проверки знания таблицы умножения");
            Random rnd = new Random();
            int k, count = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = rnd.Next(1, 11), b = rnd.Next(1, 11);
                Console.Write("{0} * {1} = ", a, b);
                k = Convert.ToInt32(Console.ReadLine());
                if (k == a * b) count++;
            }
            if (count == 10) Console.WriteLine("Отлично");
            else if (count == 9 || count == 8) Console.WriteLine("Хорошо!");
            else if (count == 7 || count == 6) Console.WriteLine("Удовлетворительно");
            else if (count < 6) Console.WriteLine("Не Удовлетворительно");
            Console.WriteLine("Повторить? Да-1 , Другое число - Нет");
            int l = Convert.ToInt16(Console.ReadLine());
            if (l == 1) goto m1;
            return;
        }
    }
}
