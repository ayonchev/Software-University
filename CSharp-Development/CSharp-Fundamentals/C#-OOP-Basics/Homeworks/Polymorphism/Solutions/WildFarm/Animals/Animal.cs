using System;
using System.Collections.Generic;
using System.Text;

public abstract class Animal
{
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.Foods = new List<string>()
        {
            nameof(Fruit), nameof(Meat), nameof(Vegetable), nameof(Seeds)
        };
    }
    protected string Name { get; set; }
    protected double Weight { get; set; }
    protected int EatenFood { get; set; }
    protected double GainWeight { get; set; }
    public List<string> Foods { get; set; }
    public abstract void AskForFood();

    public void Feed(Food currentFood)
    {
        if (this.Foods.Contains(currentFood.GetType().Name))
        {
            this.EatenFood += currentFood.Quantity;
            this.Weight += currentFood.Quantity * GainWeight;
        }
        else
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {currentFood.GetType().Name}!");
        }
    }
}
