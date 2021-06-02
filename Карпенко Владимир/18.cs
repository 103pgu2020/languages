using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
        m: Console.Write("Введите N = ");
            int k = 2, count = 0;
            int N = Int32.Parse(Console.ReadLine());
            if (N < 0) 
            { 
                Console.WriteLine("Ошибка."); 
                goto m; 
            }
            while (N >= 10)
            {
                if (count == 3) count = 0;
                if (N >= 10)
                {
                    count++;
                    k *= 2;
                    if (count == 3) k /= 2;
                    N -= 10;
                }
            }
            Console.WriteLine("В сосуде осталось - {0} антител", k);
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1) goto m;
            return;
        }
    }
}
