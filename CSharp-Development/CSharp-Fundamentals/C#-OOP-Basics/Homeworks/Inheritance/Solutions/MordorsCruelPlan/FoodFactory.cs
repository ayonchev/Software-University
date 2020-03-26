using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

public class FoodFactory
{
    public static int CalculatePointsOfHappiness(string[] foods)
    {
        int points = 0;

        for (int index = 0; index < foods.Length; index++)
        {
            points += GetFoodPoints(foods[index]);
        }

        return points;
    }

    private static int GetFoodPoints(string food)
    {
        switch (food.ToLower())
        {
            case "cram":
                return 2;
            case "lembas":
                return 3;
            case "apple":
                return 1;
            case "melon":
                return 1;
            case "honeycake":
                return 5;
            case "mushrooms":
                return -10;
        }

        return -1;
    }
}
