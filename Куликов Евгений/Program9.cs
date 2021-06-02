using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 1; i <= 64; i++)
            {
                if (i % 2 == n)
                    Console.Write("\U00002588\U00002588");
                else
                    Console.Write("  ");
                if (i % 8 == 0)
                {
                    n = (n == 1) ? 0 : 1;
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}