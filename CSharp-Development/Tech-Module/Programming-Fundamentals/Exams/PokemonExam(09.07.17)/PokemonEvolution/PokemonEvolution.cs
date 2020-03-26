using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    public class Pokemon
    {
        public string Type { get; set; }
        public int Index { get; set; }
    }

    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Pokemon>> result = new Dictionary<string, List<Pokemon>>();

            while (true)
            {
                string[] currentCommand = Console.ReadLine()
                    .Split(new char[] { ' ', '-', '>', '\t' }, 
                    StringSplitOptions.RemoveEmptyEntries);

                if (currentCommand.Length > 1)
                {
                    string pokemonName = currentCommand[0];
                    string pokemonType = currentCommand[1];
                    int pokemonIndex = int.Parse(currentCommand[2]);

                    Pokemon currentPokemon = new Pokemon()
                    {
                        Type = pokemonType,
                        Index = pokemonIndex
                    };

                    if (!result.ContainsKey(pokemonName))
                    {
                        result.Add(pokemonName, new List<Pokemon>());
                        result[pokemonName].Add(currentPokemon);
                    }
                    else
                    {
                        result[pokemonName].Add(currentPokemon);
                    }
                }
                else
                {
                    string endOrName = currentCommand[0];

                    if (endOrName == "wubbalubbadubdub")
                    {
                        break;
                    }
                    else
                    {
                        if (result.ContainsKey(endOrName))
                        {
                            Console.WriteLine($"# {endOrName}");
                            foreach (var pokemon in result[endOrName])
                            {
                                Console.WriteLine(pokemon.Type + " <-> " + pokemon.Index);
                            }
                        }
                    }
                }
            }

            foreach (var pokemonName in result)
            {
                Console.WriteLine($"# {pokemonName.Key}");
                foreach (var pokemon in pokemonName.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine(pokemon.Type + " <-> " + pokemon.Index);
                }
            }
        }
    }
}
