using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Дано натуральное число n. Вывести все простые числа < n.");
		m1: Console.Write("Введите натуральное число N: ");
			int n = Int32.Parse(Console.ReadLine());
			if (n < 1)
			{ Console.WriteLine("Ошибка!"); goto m1; }
			Console.Write("Простые числа: ");
			for (int i = 2; i < n; i++)
			{
				int count = 0;
				for (int j = 1; j <= i; j++)
					if (i % j == 0)
						count++;
				if (count <= 2)
					Console.Write(i + ", ");
			}
			Console.WriteLine();
			Console.WriteLine("Еще раз? (да - 1 нет - 0)");
			int u = Int32.Parse(Console.ReadLine());
			if (u == 1) goto m1;
			return;
		}
	}
}