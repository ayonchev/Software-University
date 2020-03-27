using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> bag;
    public string Name
    {
        get { return name; }
        set
        {
            if (value == null || value.Trim() == String.Empty)
            {
                throw new ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }

    public decimal Money
    {
        get { return money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            money = value;
        }
    }

    public List<Product> Bag
    {
        get { return this.bag; }
        private set { this.bag = value; }
    }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.Bag = new List<Product>();
    }

    public void BuyProduct(Product product)
    {
        if (this.money >= product.Cost)
        {
            this.bag.Add(product);
            this.money -= product.Cost;
            Console.WriteLine($"{this.name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{this.name} can't afford {product.Name}");
        }
    }

    public override string ToString()
    {
        if (bag.Count == 0)
        {
            return $"{this.name} - Nothing bought";
        }
        return $"{this.name} - {string.Join(", ", this.bag.Select(p => p.Name).ToList())}";
    }
}
