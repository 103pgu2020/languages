namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.Clear();
            Console.WriteLine("Программа для нахождения количества цифр в числе.");
            Console.WriteLine("Введите число:");
            int x = Int32.Parse(Console.ReadLine()), i = 0;
            if (x == 0)
                i++;
            while (x != 0)
            {
                i++;
                x /= 10;
            }
            Console.WriteLine("Количество цифр в числе = " + i);
            Console.WriteLine("\nPress 1 for restart, any other - exit.");
            x = Int32.Parse(Console.ReadLine());
            if (x == 1)
                goto st;
        }
    }
}


