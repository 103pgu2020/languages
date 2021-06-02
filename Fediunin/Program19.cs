using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			int[] rim = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
			string[] arab = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
		m: Console.WriteLine("Вв-те год (0<n<4000)");
			n = Convert.ToInt32(Console.ReadLine());
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
			Console.WriteLine("Еще раз? ( 1-да 0-нет.)");
			int a = Convert.ToInt32(Console.ReadLine());
			if (a == 1)
				goto m;
			return;
		}
	}
}