using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum0 = 0, sum1 = 0, sum2 = 0;
			double average;
			Random rand = new Random();
		m: Console.WriteLine("Программа для подсчёта среднего арифмитического трёх последовательностей");
			int[] arr1 = new int[10];
			int[] arr2 = new int[10];
			int[] arr3 = new int[10];
			Console.WriteLine("1ая последовательность");
			for (int i = 0; i < 10; i++)
			{
				arr1[i] = rand.Next(-100, 100);
				sum0 = sum0 + arr1[i];
				Console.WriteLine("arr1[{0}]={1}", i, arr1[i]);
			}
			Console.WriteLine("2ая последовательность");
			for (int i = 0; i < 10; i++)
			{
				arr2[i] = rand.Next(-100, 100);
				sum1 = sum1 + arr2[i];
				Console.WriteLine("arr2[{0}]={1}", i, arr2[i]);
			}
			Console.WriteLine("3ья последовательность");
			for (int i = 0; i < 10; i++)
			{
				arr3[i] = rand.Next(-100, 100);
				sum2 = sum2 + arr3[i];
				Console.WriteLine("arr3[{0}]={1}", i, arr3[i]);
			}
			average = (sum0 + sum1 + sum2) / 3;
			Console.WriteLine("Ср.ар 3х последовательностей: " + average);
			Console.WriteLine("Ср.ар 3х последовательностей: " + sum0);
			Console.WriteLine("Ср.ар 3х последовательностей: " + sum1);
			Console.WriteLine("Ср.ар 3х последовательностей: " + sum2);
			Console.WriteLine("Повторить? 1-Да 0 -нет.");
			int a = Convert.ToInt32(Console.ReadLine());
			if (a == 1)
				goto m;
			return;
		}
	}
}
