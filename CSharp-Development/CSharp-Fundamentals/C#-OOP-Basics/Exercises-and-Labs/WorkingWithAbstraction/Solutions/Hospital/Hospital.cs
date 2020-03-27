using System;
using System.Collections.Generic;
using System.Linq;

public class Hospital
{
    public static void Main()
    {
        Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
        Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();

        AddPerson(doctors, departments);

        Print(doctors, departments);
    }

    static void AddPerson(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments)
    {
        string personCommand;
        while ((personCommand = Console.ReadLine()) != "Output")
        {
            string[] personData = personCommand.Split();
            var department = personData[0];
            var patientName = personData[3];
            var doctorName = personData[1] + personData[2];

            if (!doctors.ContainsKey(doctorName))
            {
                doctors[doctorName] = new List<string>();
            }
            if (!departments.ContainsKey(department))
            {
                departments[department] = new List<List<string>>();
                for (int rooms = 0; rooms < 20; rooms++)
                {
                    departments[department].Add(new List<string>());
                }
            }

            FindRoom(doctorName, patientName, department, doctors, departments);
        }
    }

    static void FindRoom(string doctorName, string patientName, string department, Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments)
    {
        bool hasPlace = departments[department].SelectMany(x => x).Count() < 60;
        if (hasPlace)
        {
            int room = 0;
            doctors[doctorName].Add(patientName);
            for (int roomNumber = 0; roomNumber < departments[department].Count; roomNumber++)
            {
                if (departments[department][roomNumber].Count < 3)
                {
                    room = roomNumber;
                    break;
                }
            }
            departments[department][room].Add(patientName);
        }
    }

    static void Print(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments)
    {
        string filterCommand;
        while ((filterCommand = Console.ReadLine()) != "End")
        {
            string[] filter = filterCommand.Split();

            if (filter.Length == 1)
            {
                Console.WriteLine(string.Join("\n", departments[filter[0]].Where(x => x.Count > 0).SelectMany(x => x)));
            }
            else if (filter.Length == 2 && int.TryParse(filter[1], out int room))
            {
                Console.WriteLine(string.Join("\n", departments[filter[0]][room - 1].OrderBy(x => x)));
            }
            else
            {
                Console.WriteLine(string.Join("\n", doctors[filter[0] + filter[1]].OrderBy(x => x)));
            }
        }
    }
}
