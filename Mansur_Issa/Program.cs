using System;

namespace _5
{
    class Program
    {
        static void Output(int[] M)
        {
            for (int i = 0; i < 10; i++)
                Console.Write(M[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
        st:
            Console.Clear();
            int[] A = new int[10];
            int[] B = new int[10];
            int[] C = new int[10];
            Random random = new Random();
            int s1 = 0, s2 = 0, s3 = 0;
            double sr1, sr2, sr3;
            for (int i = 0; i<10; i++)
            {
                A[i] = random.Next(-20,21);
                s1 += A[i];
                B[i] = random.Next(-20, 21);
                s2 += B[i];
                C[i] = random.Next(-20, 21);
                s3 += C[i];
            }
            sr1 = s1 / 10.0;
            sr2 = s2 / 10.0;
            sr3 = s3 / 10.0;
            Console.WriteLine("Первый массив:");
            Output(A);
            Console.WriteLine("Среднее арифметическое: " + sr1);
            Console.WriteLine("Первый массив:");
            Output(B);
            Console.WriteLine("Среднее арифметическое: " + sr2);
            Console.WriteLine("Первый массив:");
            Output(C);
            Console.WriteLine("Среднее арифметическое: " + sr3);
            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            s1 = Int32.Parse(Console.ReadLine());
            if (s1 == 1)
                goto st;
        }
    }
}
