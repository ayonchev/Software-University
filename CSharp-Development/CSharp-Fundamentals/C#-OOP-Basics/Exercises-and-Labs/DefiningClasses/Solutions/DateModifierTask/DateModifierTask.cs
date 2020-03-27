using System;

public class DateModifierTask
{
    static void Main(string[] args)
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        Console.WriteLine(new DateModifier(firstDate, secondDate).Difference);
    }
}

