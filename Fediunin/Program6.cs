using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b, c;
			Console.WriteLine("Программа, которая выводит трёхназчные числа, сумма цифр которых меньше заданного n");
		m: Console.WriteLine("Вв-те n");
			double n = Convert.ToDouble(Console.ReadLine());
			if (n < 0)
			{
				Console.WriteLine("Вв-те положительное n");
				goto m;
			}
			for (int i = 100; i < 1000; i++)
			{
				a = i / 100;
				b = i / 10 % 10;
				c = i % 10;
				if ((a + b + c) < n)
					Console.WriteLine(i);
			}
			Console.WriteLine("Повторить? 1-Да 0-нет.");
			int l = Convert.ToInt32(Console.ReadLine());
			if (l == 1)
				goto m;
			return;

		}
	}
}