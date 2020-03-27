
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;



public class Startup
{
    public static void Main()
    {
        // Store ppl with full information
        var people = new List<Person>();

        // Store string for ppl with partial information for later use
        var storePeople = new List<string>();

        var person = Console.ReadLine();

        var inputLine = Console.ReadLine();

        while (!inputLine.Equals("End"))
        {
            var info = Regex.Split(inputLine, " - ");

            if (info.Length == 1) // Full person information given
            {
                var lastIndexOfSpace = inputLine.LastIndexOf(" ", StringComparison.Ordinal);

                var name = inputLine.Substring(0, lastIndexOfSpace);
                var birthday = inputLine.Substring(lastIndexOfSpace + 1);

                var newPerson = new Person(name, birthday);

                people.Add(newPerson);
            }
            else
            {
                storePeople.Add(inputLine);
            }

            inputLine = Console.ReadLine();
        }

        // We will see what we have in storePeople for our parent/children relations
        foreach (var storePerson in storePeople)
        {
            Person parent;
            Person children;

            var info = Regex.Split(storePerson, " - ");

            if (info[0].Contains('/') && info[1].Contains('/')) // Both inputs are dates of birthday
            {
                var parentBirhtday = info[0];
                var childrenBirthday = info[1];

                parent = people
                        .First(p => p.Birthday.Equals(parentBirhtday)); // We searcg for the current person in our list
                children = people
                        .First(p => p.Birthday.Equals(childrenBirthday)); // We searcg for the current person in our list
            }
            else if (info[0].Contains('/') || info[1].Contains('/')) // One of the inputs is date
            {
                var name = string.Empty;
                var birthday = string.Empty;

                if (info[0].Contains('/')) // First is date
                {
                    birthday = info[0];
                    name = info[1];

                    parent = people
                        .First(p => p.Birthday.Equals(birthday));
                    children = people
                        .First(p => p.Name.Equals(name));
                }
                else // Second is date
                {
                    birthday = info[1];
                    name = info[0];

                    children = people
                        .First(p => p.Birthday.Equals(birthday));
                    parent = people
                        .First(p => p.Name.Equals(name));
                }
            }
            else // Both are names
            {
                var parentName = info[0];
                var childrenName = info[1];

                parent = people
                        .First(p => p.Name.Equals(parentName));
                children = people
                        .First(p => p.Name.Equals(childrenName));
            }

            if (!parent.Children.Contains(children))
            {
                parent.Children.Add(children);
            }

            if (!children.Parents.Contains(parent))
            {
                children.Parents.Add(parent);
            }
        }

        Person ourPerson;

        // Chech if the info for our person is Name or Date
        if (person.Contains('/'))
        {
            ourPerson = people.First(p => p.Birthday.Equals(person));
        }
        else
        {
            ourPerson = people.First(p => p.Name.Equals(person));
        }

        var result = new StringBuilder();

        result.AppendLine(ourPerson.ToString());

        result.AppendLine("Parents:");
        foreach (var parent in ourPerson.Parents)
        {
            result.AppendLine(parent.ToString());
        }

        result.AppendLine("Children:");
        foreach (var child in ourPerson.Children)
        {
            result.AppendLine(child.ToString());
        }

        Console.Write(result);
    }
}
