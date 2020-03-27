using System;

public class MordorsCruelPlan
{
    static void Main()
    {
        string[] foods = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        Player currentPlayer = new Player(foods);

        Console.WriteLine(currentPlayer.PointsOfHapppiness);
        Console.WriteLine(currentPlayer.Mood);
    }
}
