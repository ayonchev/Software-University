using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CommandExecutor
{
    public void ExecuteCommand(string command, List<PetClinic> clinics, List<Pet> pets)
    {
        string[] commandData = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        string commandType = commandData[0];
        string petName = string.Empty;
        string clinicName = string.Empty;
        PetClinic currentClinic = null;

        try
        {
            switch (commandType)
            {
                case "Create":
                    if (commandData[1] == "Clinic")
                    {
                        clinicName = commandData[2];
                        int numberOfRooms = int.Parse(commandData[3]);

                        clinics.Add(new PetClinic(clinicName, numberOfRooms));
                    }
                    else if (commandData[1] == "Pet")
                    {
                        petName = commandData[2];
                        int age = int.Parse(commandData[3]);
                        string kind = commandData[4];

                        pets.Add(new Pet(petName, age, kind));
                    }
                    break;
                case "Add":
                    petName = commandData[1];
                    clinicName = commandData[2];
                    currentClinic = clinics.FirstOrDefault(c => c.Name == clinicName);
                    var currentPet = pets.FirstOrDefault(p => p.Name == petName);

                    Console.WriteLine(currentClinic.AddPet(currentPet));
                    break;
                case "Release":
                    clinicName = commandData[1];
                    currentClinic = clinics.FirstOrDefault(c => c.Name == clinicName);

                    Console.WriteLine(currentClinic.Release());
                    break;
                case "Print":
                    clinicName = commandData[1];
                    currentClinic = clinics.FirstOrDefault(c => c.Name == clinicName);
                    if (commandData.Length < 3)
                    {
                        Console.Write(currentClinic.PrintAll());
                    }
                    else
                    {
                        int roomIndex = int.Parse(commandData[2]);
                        Console.WriteLine(currentClinic.PrintRoom(roomIndex));
                    }
                    break;
                case "HasEmptyRooms":
                    clinicName = commandData[1];
                    currentClinic = clinics.FirstOrDefault(c => c.Name == clinicName);

                    Console.WriteLine(currentClinic.HasEmptyRooms);
                    break;
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Operation!");
        }
    }
}
