using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Есть только одна команда вывода пробела на экран, одна команда вывода звёздочки и одна команда переноса строки.
            Вывести шахматную доску. Можно использовать эти команды вывода только по одному раз.*/
            Console.WriteLine("Программа, которая выводи на экран схему шахматной доски");
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    if ((i + k) % 2 == 0)
                        Console.Write((char)'\u2588');
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            return;
        }
    }
}
