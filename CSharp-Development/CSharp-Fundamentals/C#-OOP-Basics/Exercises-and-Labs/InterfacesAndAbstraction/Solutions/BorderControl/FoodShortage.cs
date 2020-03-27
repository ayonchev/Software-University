using System;
using System.Collections.Generic;
using System.Linq;

public class FoodShortage
{
    static void Main()
    {
        int numberOfPeople = int.Parse(Console.ReadLine());

        Dictionary<string, IBuyer> people = AddPeople(numberOfPeople);

        people = BuyFood(people);

        Console.WriteLine(people.Sum(p => p.Value.FoodAmount));
    }

    private static Dictionary<string, IBuyer> BuyFood(Dictionary<string, IBuyer> people)
    {
        string currentPerson;
        while ((currentPerson = Console.ReadLine()) != "End")
        {
            if (people.ContainsKey(currentPerson))
            {
                people[currentPerson].BuyFood();
            }
        }

        return people;
    }

    private static Dictionary<string, IBuyer> AddPeople(int numberOfPeople)
    {
        Dictionary<string, IBuyer> resultDict = new Dictionary<string, IBuyer>();

        for (int count = 0; count < numberOfPeople; count++)
        {
            string[] personData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (!resultDict.ContainsKey(personData[0]))
            {
                if (personData.Length == 4)
                {
                    resultDict.Add(personData[0], (IBuyer)new Citizen());
                }
                else
                {
                    resultDict.Add(personData[0], (IBuyer)new Rebel());
                }
            }
        }

        return resultDict;
    }
}
