using System;
using System.Collections.Generic;
using System.Linq;

public class GreedyTimes
{
    static void Main(string[] args)
    {
        long bagCapacity = long.Parse(Console.ReadLine());
        string[] safe = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var bag = AddItems(bagCapacity, safe);
        
        PrintItems(bag);
    }

    static Dictionary<string, Dictionary<string, long>> AddItems(long bagCapacity, string[] safe)
    {
        Dictionary<string, Dictionary<string, long>> bag = new Dictionary<string, Dictionary<string, long>>();

        for (int index = 0; index < safe.Length; index += 2)
        {
            string item = safe[index];
            long amount = long.Parse(safe[index + 1]);

            string itemType = GetItemType(item);

            if (itemType == "" || 
                !ItemCanBeAdded(itemType, amount, bag) || 
                bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + amount)
            {
                continue;
            }

            if (!bag.ContainsKey(itemType))
            {
                bag[itemType] = new Dictionary<string, long>();
            }

            if (!bag[itemType].ContainsKey(item))
            {
                bag[itemType][item] = 0;
            }
            bag[itemType][item] += amount;
        }
        return bag;
    }

    static bool ItemCanBeAdded(string itemType,long amount, Dictionary<string, Dictionary<string, long>> bag)
    {
        switch (itemType)
        {
            case "Gem":
                if (!bag.ContainsKey(itemType))
                {
                    if (bag.ContainsKey("Gold"))
                    {
                        if (amount > bag["Gold"].Values.Sum())
                        {
                            return  false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (bag[itemType].Values.Sum() + amount > bag["Gold"].Values.Sum())
                {
                    return false;
                }
                break;
            case "Cash":
                if (!bag.ContainsKey(itemType))
                {
                    if (bag.ContainsKey("Gem"))
                    {
                        if (amount > bag["Gem"].Values.Sum())
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (bag[itemType].Values.Sum() + amount > bag["Gem"].Values.Sum())
                {
                    return false;
                }
                break;
        }

        return true;
    }

    static string GetItemType(string item)
    {
        string itemType = string.Empty;

        if (item.Length == 3)
        {
            itemType = "Cash";
        }
        else if (item.ToLower().EndsWith("gem"))
        {
            itemType = "Gem";
        }
        else if (item.ToLower() == "gold")
        {
            itemType = "Gold";
        }

        return itemType;
    }

    static void PrintItems(Dictionary<string, Dictionary<string, long>> bag)
    {
        foreach (var itemType in bag)
        {
            Console.WriteLine($"<{itemType.Key}> ${itemType.Value.Values.Sum()}");
            foreach (var item in itemType.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
            {
                Console.WriteLine($"##{item.Key} - {item.Value}");
            }
        }
    }
}
