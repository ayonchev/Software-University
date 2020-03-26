using System;
using System.Collections.Generic;
using System.Text;

public class ItemFactory
{
    public Item CreateItem(string itemName)
    {
        switch (itemName)
        {
            case "PoisonPotion":
                return  new PoisonPotion();
            case "HealthPotion":
                return  new HealthPotion();
            case "ArmorRepairKit":
                return  new ArmorRepairKit();
            default:
                throw new ArgumentException($"Invalid item \"{itemName}\"!");
        }
    }
}

