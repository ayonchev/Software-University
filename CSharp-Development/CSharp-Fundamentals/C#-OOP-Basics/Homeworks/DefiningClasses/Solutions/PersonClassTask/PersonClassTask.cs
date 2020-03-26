using System;
using System.Linq;

public class PersonClassTask
{
    static void Main(string[] args)
    {
        int numberOfMembers = int.Parse(Console.ReadLine());
        Family family = new Family();

        for (int i = 0; i < numberOfMembers; i++)
        {
            string[] currentMember = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string name = currentMember[0];
            int age = int.Parse(currentMember[1]);

            Person currentPerson = new Person(name, age);

            family.AddMember(currentPerson);
        }

        foreach (var currentMember in family.GetOlderThan30().OrderBy(x => x.Name))
        {
            
            Console.WriteLine(currentMember.ToString());
        }
    }
}
