using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main()
        {
        m: Console.Write("Введите n: ");
            int n = Int32.Parse(Console.ReadLine());
            if (n <= 0 || n >= 4000)
            {
                Console.WriteLine("Ошибка.");
                goto m;
            }
            Console.WriteLine("Арабскими: {0}", n);
            int count, q = 1000;
            string result = "";
            while (true)
            {
                count = 0;
                if (q == 0) break;
                count = n / q;
                if (true)
                {
                    n %= q;
                    for (int i = 0; i < count; i++)
                        switch (q)
                        {
                            case 1000: { result += "M"; break; }
                            case 900: { result += "CM"; break; }
                            case 800: { result += "DCC"; break; }
                            case 700: { result += "DCC"; break; }
                            case 600: { result += "DC"; break; }
                            case 500: { result += "D"; break; }
                            case 400: { result += "CD"; break; }
                            case 300: { result += "CCC"; break; }
                            case 200: { result += "CC"; break; }
                            case 100: { result += "C"; break; }
                            case 90: { result += "XC"; break; }
                            case 80: { result += "LXXX"; break; }
                            case 70: { result += "LXX"; break; }
                            case 60: { result += "LX"; break; }
                            case 50: { result += "L"; break; }
                            case 40: { result += "XL"; break; }
                            case 30: { result += "XXX"; break; }
                            case 20: { result += "XX"; break; }
                            case 10: { result += "X"; break; }
                            case 9: { result += "IX"; break; }
                            case 8: { result += "VIII"; break; }
                            case 7: { result += "VII"; break; }
                            case 6: { result += "VI"; break; }
                            case 5: { result += "V"; break; }
                            case 4: { result += "IV"; break; }
                            case 3: { result += "III"; break; }
                            case 2: { result += "II"; break; }
                            case 1: { result += "I"; break; }
                        }
                }
                if (q <= 1000 && q > 100) q -= 100;
                else if (q <= 100 && q > 10) q -= 10;
                else q -= 1;
            }
            Console.WriteLine("Римскими: {0}", result);
            Console.WriteLine("Введите 1, чтобы повторить или другую цифру для продолжения: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1) goto m;
            return;
        }
    }
}