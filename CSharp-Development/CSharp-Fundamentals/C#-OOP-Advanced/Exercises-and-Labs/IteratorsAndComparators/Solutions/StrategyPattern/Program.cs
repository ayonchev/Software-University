using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int numberOfPeople = int.Parse(Console.ReadLine());

        var peopleSortedByName = new SortedSet<Person>(new PersonNameComparator());
        var peopleSortedByAge = new SortedSet<Person>(new PersonAgeComparator());

        for (int personIndex = 0; personIndex < numberOfPeople; personIndex++)
        {
            string[] currentPersonData =
                Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string name = currentPersonData[0];
            int age = int.Parse(currentPersonData[1]);

            peopleSortedByName.Add(new Person(name, age));
            peopleSortedByAge.Add(new Person(name, age));
        }

        foreach (var person in peopleSortedByName)
        {
            Console.WriteLine(person);
        }

        foreach (var person in peopleSortedByAge)
        {
            Console.WriteLine(person);
        }
    }
}
