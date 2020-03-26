using System;
using System.Collections.Generic;
using System.Text;

public class Topping
{
    private const double MIN_WEIGHT = 1;
    private const double MAX_WEIGHT = 50;

    private string type;
    private double caloriesPerType;
    private double weight;
    private double calories;

    public double Calories
    {
        get { return this.calories; }
    }
    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }

    public Topping(string type, double weight)
    {
        this.type = type;
        this.caloriesPerType = GetCaloriesPerType();
        this.Weight = weight;
        this.calories = CalculateCalories();
    }

    private double CalculateCalories()
    {
        return this.caloriesPerType * weight * 2;
    }

    private double GetCaloriesPerType()
    {
        double calories = 1;

        switch (this.type.ToLower())
        {
            case "meat":
                calories = 1.2;
                break;
            case "veggies":
                calories = 0.8;
                break;
            case "cheese":
                calories = 1.1;
                break;
            case "sauce":
                calories = 0.9;
                break;
            default:
                throw new ArgumentException($"Cannot place {this.type} on top of your pizza.");
        }

        return calories;
    }

    public override string ToString()
    {
        return this.calories.ToString("F2");
    }
}
