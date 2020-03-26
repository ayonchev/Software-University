using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        var peopleInSortedSet = new SortedSet<Person>();
        var peopleInHashSet = new HashSet<Person>();

        int numberOfPeople = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPeople; i++)
        {
            string[] personData = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string name = personData[0];
            int age = int.Parse(personData[1]);

            peopleInHashSet.Add(new Person(name, age));
            peopleInSortedSet.Add(new Person(name, age));
        }

        Console.WriteLine(peopleInSortedSet.Count);
        Console.WriteLine(peopleInHashSet.Count);
    }
}
