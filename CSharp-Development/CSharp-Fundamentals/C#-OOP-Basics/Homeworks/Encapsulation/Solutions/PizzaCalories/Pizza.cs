using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Pizza
{
    private string name;
    private List<Topping> toppings;
    private double calories;
    private Dough dough;

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Trim() == String.Empty || value.Length > 15 || value == null)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }
    public List<Topping> Toppings
    {
        get { return toppings; }
        private set { toppings = value; }
    }
    public double Calories
    {
        get { return this.calories; }
        private set { this.calories = value; }
    }
    public Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }

    public Pizza(string name)
    {
        this.Name = name;
        this.Toppings = new List<Topping>();
    }

    public void AddTopping(Topping topping)
    {
        if (this.toppings.Count == 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
        this.toppings.Add(topping);
    }

    private double CalculateCalories()
    {
        return this.Toppings.Sum(t => t.Calories) + this.dough.Calories;
    }

    public override string ToString()
    {
        this.calories = CalculateCalories();
        return $"{this.name} - {this.calories:F2} Calories.";
    }
}
