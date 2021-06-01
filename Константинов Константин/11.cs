using System;

class Program
{
    static void Main()
    {
        n1:  Console.Write("������ �������� ��� (����): ");
        int startHours = int.Parse(Console.ReadLine());
        Console.Write("������ �������� ��� (������): ");
        int startMinutes = int.Parse(Console.ReadLine());
        Console.Write("����������������� ���� (����): ");
        int pairDurationHours = int.Parse(Console.ReadLine());
        Console.Write("����������������� ���� (������): ");
        int pairDurationMinutes = int.Parse(Console.ReadLine());
        Console.Write("����������������� �������� (� �������): ");
        int breakDuration = int.Parse(Console.ReadLine());
        Console.Write("���������� ���: ");
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

        Console.Write("���������? (1 - ��, 0 - ���) ");
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            goto n1;
        }
    }
}