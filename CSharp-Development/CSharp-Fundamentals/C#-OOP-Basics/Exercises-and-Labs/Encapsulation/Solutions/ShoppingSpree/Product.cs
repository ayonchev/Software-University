using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
    private string name;
    private decimal cost;
    public string Name
    {
        get { return name; }
        set
        {
            if (value.Trim() == string.Empty || value == null)
            {
               throw new ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }

    public decimal Cost
    {
        get { return cost; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            cost = value;
        }
    }

    public Product(string name, decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    }
}
