using System;


namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Для записи римскими цифрами используются символы:
            I, V, X, L, C, D, M, обозначающие соответственно числа
            1, 5, 10, 50, 100, 500, 1000. Составить программу,
            которая запись любого данного числа n (n<4000) арабскими цифрами
            переводила бы в запись римскими цифрами.*/
            int[] rim = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] arab = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        m: Console.Write("\nВведите год (0 < n < 4000): ");
            int n = Convert.ToInt32(Console.ReadLine());
            string str = "";
            int i = 0;
            if (n < 1 || n > 3999)
            {
                Console.WriteLine("Вы ввели неверное число");
                goto m;
            }
            while (n > 0)
            {
                if (rim[i] <= n)
                {
                    n = n - rim[i];
                    str = str + arab[i];
                }
                else i++;
            }
            Console.WriteLine(str);
            Console.WriteLine("\nПовторить? 1-Да; Любое другое число-нет.");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
                goto m;
            return;
        }
    }
}
