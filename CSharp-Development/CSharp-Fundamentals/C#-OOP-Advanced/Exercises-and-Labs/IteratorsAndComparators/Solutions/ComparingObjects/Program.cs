using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        var personCollection = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] personData = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string name = personData[0];
            int age = int.Parse(personData[1]);
            string town = personData[2];

            personCollection.Add(new Person(name, age, town));
        }

        int chosenPersonIndex = int.Parse(Console.ReadLine());
        var chosenPerson = personCollection[chosenPersonIndex - 1];
        int equalPeople = personCollection.FindAll(p => p.CompareTo(chosenPerson) == 0).Count;
        int notEqualPeople = personCollection.Count - equalPeople;

        if (equalPeople < 2)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{equalPeople} {notEqualPeople} {personCollection.Count}");
        }
    }
}

