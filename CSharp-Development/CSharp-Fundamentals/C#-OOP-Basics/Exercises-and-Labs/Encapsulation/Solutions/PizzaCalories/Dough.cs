using System;
using System.Collections.Generic;
using System.Text;

public class Dough
{
    private const double MIN_WEIGHT = 1;
    private const double MAX_WEIGHT = 200;

    private double weight;
    private double flourTypeModifier;
    private double bakingTechniqueModifier;
    private double calories;

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            weight = value;
        }
    }

    public double Calories
    {
        get { return this.calories; }
    }
    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.Weight = weight;
        this.flourTypeModifier= GetFlourModifier(flourType);
        this.bakingTechniqueModifier = GetBakingTechniqueModifier(bakingTechnique);
        this.calories = CalculateCalories();
    }

    private double CalculateCalories()
    {
        return (2 * this.Weight) * this.flourTypeModifier * this.bakingTechniqueModifier;
    }

    private double GetBakingTechniqueModifier(string bakingTechnique)
    {
        double modifier = 1;

        switch (bakingTechnique.ToLower())
        {
            case "crispy":
                modifier = 0.9;
                break;
            case "chewy":
                modifier = 1.1;
                break;
            case "homemade":
                modifier = 1;
                break;
            default:
                throw new ArgumentException("Invalid type of dough.");
        }

        return modifier;
    }

    private double GetFlourModifier(string flourType)
    {
        double modifier = 1;

        switch (flourType.ToLower())
        {
            case "white":
                modifier = 1.5;
                break;
            case "wholegrain":
                modifier = 1.0;
                break;
            default:
                throw new ArgumentException("Invalid type of dough.");
        }

        return modifier;
    }

    public override string ToString()
    {
        return this.calories.ToString("F2");
    }
}
