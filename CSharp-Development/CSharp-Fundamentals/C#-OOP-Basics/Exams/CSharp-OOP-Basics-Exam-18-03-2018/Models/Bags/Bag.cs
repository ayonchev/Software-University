using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public abstract class Bag
{
    private const int CapacityDefaultValue = 100;

    public int Capacity { get; private set; }
    public double Load { get; private set; }
    public IReadOnlyCollection<Item> Items { get; private set; }

    protected Bag(int capacity = CapacityDefaultValue)
    {
        this.Capacity = capacity;
        this.Items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        this.Load = Items.Sum(i => i.Weight);

        if (Load + item.Weight > Capacity)
        {
            throw new InvalidOperationException("Bag is full!");
        }

        List<Item> currentCollection = new List<Item>(Items);
        currentCollection.Add(item);

        Items = new ReadOnlyCollection<Item>(currentCollection);
    }

    public Item GetItem(string name)
    {
        if (Items.Count == 0)
        {
            throw new InvalidOperationException("Bag is empty!");
        }
        else if (!Items.Any(i => i.Name == name))
        {
            throw new ArgumentException($"No item with name {name} in bag!");
        }
        else
        {
            Item currItem = Items.FirstOrDefault(i => i.Name == name);
            List<Item> newCollection = new List<Item>(Items);
            newCollection.Remove(currItem);
            Items = new ReadOnlyCollection<Item>(newCollection);

            return currItem;
        }
    }
}