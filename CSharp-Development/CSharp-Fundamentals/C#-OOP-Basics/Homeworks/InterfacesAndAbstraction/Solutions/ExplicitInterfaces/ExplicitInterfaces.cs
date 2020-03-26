using System;

class ExplicitInterfaces
{
    static void Main()
    {
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] citizenData = input.Split();
            Citizen currentCitizen = new Citizen(citizenData[0], citizenData[1], int.Parse(citizenData[2]));
            Console.WriteLine(((IPerson)currentCitizen).GetName());
            Console.WriteLine(GetResidentName(currentCitizen));
        }
    }

    static string GetResidentName(Citizen currCitizen)
    {
        return ((IResident) currCitizen).GetName() + " " + ((IPerson) currCitizen).GetName();
    }
}
