using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
	class Program
	{
		static void Main(string[] args)
		{
		m:
			Console.Clear();
			Console.WriteLine("Введите число:");
			int N = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Цифры, которые отсутствуют:");
			for (int i = 9; i >= 0; i--)
			{
				int n = N;
				int k = 10;
				while (n != 0 && k != i)
				{
					k = n % 10;
					n = n / 10;
				}
				if (k != i)
					Console.Write(i + " ");
			}
			Console.WriteLine("Повторить? 1-Да 0-нет.");
			int x = Int32.Parse(Console.ReadLine());
			if (x == 1)
				goto m;
		}
	}
}