using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Вывести на экран первые k членов ряда Фибоначчи. (1, 1, 2, 3, 5, 8...)");
		m1: Console.Write("Сколько нужно вывести членов последовательности Фибоначчи? N: ");
			int n, a = 0, b = 1, s = 0, k = 1;
			n = Int32.Parse(Console.ReadLine());
			if (n < 0) { Console.WriteLine("Ошибка! Введите другое значение!"); goto m1; }
			while (k <= n)
			{
				s = a + b;
				a = b;
				b = s;
				k++;
				Console.Write(a + " ");
			}
			Console.WriteLine();
			Console.WriteLine("Еще раз? (1 - да 0- нет");
			int u = Int32.Parse(Console.ReadLine());
			if (u == 1) goto m1;
			return;
		}
	}
}