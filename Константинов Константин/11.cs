using System;

class Program
{
    static void Main()
    {
        n1:  Console.Write("Начало учебного дня (часы): ");
        int startHours = int.Parse(Console.ReadLine());
        Console.Write("Начало учебного дня (минуты): ");
        int startMinutes = int.Parse(Console.ReadLine());
        Console.Write("Продолжительность пары (часы): ");
        int pairDurationHours = int.Parse(Console.ReadLine());
        Console.Write("Продолжительность пары (минуты): ");
        int pairDurationMinutes = int.Parse(Console.ReadLine());
        Console.Write("Продолжительность перерыва (в минутах): ");
        int breakDuration = int.Parse(Console.ReadLine());
        Console.Write("Количество пар: ");
        int pairsCount = int.Parse(Console.ReadLine());
        int pairDuration = pairDurationHours * 60 + pairDurationMinutes;

        for (int pair = 1; pair <= pairsCount; pair++)
        {
            Console.Write("{0}) {1:00}:{2:00} - ", pair, startHours, startMinutes);
            startHours = startHours + (startMinutes + pairDuration) / 60;
            startMinutes = (startMinutes + pairDuration) % 60;
            Console.WriteLine("{0:00}:{1:00}", startHours, startMinutes);
            startHours = startHours + (startMinutes + breakDuration) / 60;
            startMinutes = (startMinutes + breakDuration) % 60;
        }

        Console.Write("Повторить? (1 - да, 0 - нет) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}