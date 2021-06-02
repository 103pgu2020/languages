using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Карасев_Иван_8
{
    class Program
    {
        static void Main(string[] args)
        {
        m1: Console.Write("Натуральное N: ");
            string N = Console.ReadLine();
            int[] n1 = new int[N.Length];
            for (int i = 0; i < N.Length; i++)
            n1[i] = int.Parse(N[i].ToString());
            Array.Sort(n1);
            Array.Reverse(n1);
            foreach (int n in n1)
            Console.Write($"{n} ");
            Console.Write("\n\nЕщё раз? (1 - да, 0 - нет) ");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                goto m1;
            }
        }
    }
}
