using System;

class Program
{
    static void Main()
    {
    n1: Console.Write("����������� N: ");
        string N = Console.ReadLine();
        int[] nums = new int[N.Length];
        int a, b;

        for (int i = 0; i < N.Length; i++)
            nums[i] = int.Parse(N[i].ToString());

        Array.Sort(nums);
        Array.Reverse(nums);

        foreach (int num in nums)
            Console.Write($"{num} ");

        Console.Write("\n\n���������? (1 - ��, 0 - ���) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}