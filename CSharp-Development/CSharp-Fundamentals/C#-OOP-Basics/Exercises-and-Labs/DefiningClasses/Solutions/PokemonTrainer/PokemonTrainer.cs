using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonTrainer
{
    static void Main()
    {
        string input;
        List<Trainer> trainers = new List<Trainer>();

        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] currentTrainerDetails =
                input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string trainerName = currentTrainerDetails[0];
            string pokemonName = currentTrainerDetails[1];
            string pokemonElement = currentTrainerDetails[2];
            double pokemonHealth = double.Parse(currentTrainerDetails[3]);

            Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            Trainer currentTrainer = new Trainer(trainerName, currentPokemon);
            if (trainers.Any(x => x.Name == trainerName))
            {
                currentTrainer = trainers.Where(x => x.Name == trainerName).FirstOrDefault();
                currentTrainer.Pokemons.Add(currentPokemon);
            }
            else
            {
                trainers.Add(currentTrainer);
            }
        }

        while ((input = Console.ReadLine()) != "End")
        {
            string currentElement = input;
            for (int trainer = 0; trainer < trainers.Count; trainer++)
            {
                trainers[trainer].CheckForElement(currentElement);
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
        }
    }
}
