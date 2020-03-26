using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Snowwhite
{
    
    public class Snowwhite
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input != "Once upon a time")
                {
                    string pattern = @"([^\s\<\:\>]+)(?:\s\<\:\>\s)([^\s\<\:\>]+)(?:\s\<\:\>\s)(\d+)";

                    string dwarfName = Regex.Match(input, pattern).Groups[1].Value;
                    string dwarfHat = Regex.Match(input, pattern).Groups[2].Value;
                    int dwarfPhysics = int.Parse(Regex.Match(input, pattern).Groups[3].Value);

                    if (result.ContainsKey(dwarfHat))
                    {
                        if (result[dwarfHat].ContainsKey(dwarfName))
                        {
                            if (result[dwarfHat][dwarfName] < dwarfPhysics)
                            {
                                result[dwarfHat][dwarfName] = dwarfPhysics;
                            }
                        }
                        else
                        {
                            result[dwarfHat].Add(dwarfName, dwarfPhysics);
                        }
                    }
                    else
                    {
                        var currentDwarf = new Dictionary<string, int>();
                        currentDwarf.Add(dwarfName, dwarfPhysics);
                        result.Add(dwarfHat, currentDwarf);
                    }
                }
                else
                {
                    break;
                }
            }

            foreach (var hatColor in result.OrderByDescending(x => x.Value.Values.Min()).ThenByDescending(x => x.Value.Keys.Count))
            {
                Dictionary<string, int> currentDwarf = hatColor.Value;

                foreach (var dwarf in currentDwarf)
                {
                    Console.WriteLine($"({hatColor.Key}) {dwarf.Key} <-> {dwarf.Value}");   
                }
            }
        }
    }
}
