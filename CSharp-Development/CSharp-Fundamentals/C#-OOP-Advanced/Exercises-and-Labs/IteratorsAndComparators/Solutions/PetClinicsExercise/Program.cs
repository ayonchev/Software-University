using System;
using System.Collections.Generic;
using System.Linq;

namespace PetClinicsExercise
{
    class Program
    {
        static void Main()
        {
            List<PetClinic> clinics = new List<PetClinic>();
            List<Pet> pets = new List<Pet>();
            var executor = new CommandExecutor();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int commandIndex = 0; commandIndex < numberOfCommands; commandIndex++)
            {
                string currentCommand = Console.ReadLine();
                executor.ExecuteCommand(currentCommand, clinics, pets);
            }
        }
    }
}
