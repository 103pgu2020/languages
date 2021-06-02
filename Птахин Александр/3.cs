using System;

class Program
{
    static void Main()
    {
    m1: int n= 0;
        int p = 0;
        int a = 1;
        while (a!=0)
        {
            Console.Write("число: ");
             a = int.Parse(Console.ReadLine());

            
                if (p * a < 0 && p != 0)
                   n++;
                p = a;
            
        }
        Console.WriteLine("количечтво смен знака: "+n) ;

        Console.WriteLine("Ещё раз? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto m1;
        }
    }
}