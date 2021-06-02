using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();

                Random random = new Random();

                Console.WriteLine("Проверка знания таблицы");
                int k = 0;

                for (int i = 1; i <= 10; i++)
                {
                    int a = random.Next(-20, 21);
                    int b = random.Next(-20, 21);
                    Console.WriteLine("Вопрос {0}.\n({1})*({2})=", i, a, b);
                    int p = Int32.Parse(Console.ReadLine());
                    if (p == a * b)
                    {
                        Console.WriteLine("Ответ верный!\n");
                        k++;
                    }
                    else
                        Console.WriteLine("Ответ неверный!\n");
                }
                Console.WriteLine("Набрано {0} баллов.", k);
                Console.Write("Результат: ");
                if (k < 6)
                    Console.WriteLine("незачёт!");
                else if (k < 8)
                    Console.WriteLine("удовлетворительно!");
                else if (k < 10)
                    Console.WriteLine("хорошо!");
                else
                    Console.WriteLine("отлично!");

            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            int x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}