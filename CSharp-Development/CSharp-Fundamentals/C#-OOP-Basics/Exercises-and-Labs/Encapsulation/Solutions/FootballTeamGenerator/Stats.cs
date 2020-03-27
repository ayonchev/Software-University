using System;
using System.Collections.Generic;
using System.Text;

public class Stats
{
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;
    private double skillLevel;

    public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
        this.SkillLevel = (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
    }

    public int Endurance
    {
        get { return endurance; }
        set
        {
            Validator.ValidateStat("Endurance", value);
            endurance = value;
        }
    }

    public int Sprint
    {
        get { return sprint; }
        set
        {
            Validator.ValidateStat("Sprint", value);
            sprint = value;
        }
    }
    public int Dribble
    {
        get { return dribble; }
        set
        {
            Validator.ValidateStat("Dribble", value);
            dribble = value;
        }
    }
    public int Passing
    {
        get { return passing; }
        set
        {
            Validator.ValidateStat("Passing", value);
            passing = value;
        }
    }

    public int Shooting
    {
        get { return shooting; }
        set
        {
            Validator.ValidateStat("Shooting", value);
            shooting = value;
        }
    }
    public double SkillLevel
    {
        get { return skillLevel; }
        set { skillLevel = value; }
    }
}
