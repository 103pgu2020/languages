using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
	class Program
	{
		static void Main(string[] args)
		{
			int N, k = 0, i = 0;
			Console.WriteLine("Программа нахождения делителей");
		m1: Console.WriteLine("Введите натуральное число N");
			Console.Write("N: ");
			N = Convert.ToInt16(Console.ReadLine());
			if (N < 1)
			{
				Console.WriteLine("Ошибка ввода повторите ещё");
				goto m1;
			}
			Console.WriteLine("Делители:");
			for (i = 1; i <= N; i++)
			{
				if (N % i == 0)
				{
					Console.WriteLine(i);
					k++;
				}
			}
			Console.WriteLine("Кол-во делителей:" + k);
			Console.WriteLine("Продолжить? (1 - да 0 - нет) ");
			if (Console.ReadLine() == "1")
			{
				Console.Clear();
				goto m1;
			}
			else
			return;
		}
	}
}