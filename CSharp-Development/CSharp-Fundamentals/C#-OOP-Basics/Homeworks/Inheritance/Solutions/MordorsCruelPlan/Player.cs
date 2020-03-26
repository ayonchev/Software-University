using System;
using System.Collections.Generic;
using System.Text;

public class Player
{
    private string mood;
    private int pointsOfHapppiness;

    public Player(string[] foods)
    {
        this.pointsOfHapppiness = FoodFactory.CalculatePointsOfHappiness(foods);
        this.mood = MoodFactory.GetMood(this.pointsOfHapppiness);
    }
    public string Mood
    {
        get { return mood; }
        private set { mood = value; }
    }
    public int PointsOfHapppiness
    {
        get { return pointsOfHapppiness; }
        private set { pointsOfHapppiness = value; }
    }
}
