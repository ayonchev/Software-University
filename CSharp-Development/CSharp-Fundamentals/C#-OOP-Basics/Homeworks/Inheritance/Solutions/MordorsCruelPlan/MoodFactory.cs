using System;
using System.Collections.Generic;
using System.Text;

public class MoodFactory
{
    public static string GetMood(int pointsOfHappiness)
    {
        if (pointsOfHappiness < -5)
        {
            return "Angry";
        }
        else if (pointsOfHappiness >= -5 && pointsOfHappiness <= 0)
        {
            return "Sad";
        }
        else if (pointsOfHappiness >= 1 && pointsOfHappiness <= 15)
        {
            return "Happy";
        }

        return "JavaScript";
    }
}
