using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main()
    {
        List<int> stones = Console.ReadLine()
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var newLake = new Lake(stones);

        Console.WriteLine(newLake.PrintStones());
    }
}
