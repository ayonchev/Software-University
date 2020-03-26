using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowmen
{
    class Snowmen
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (snowmen.Count > 1)
            {
                List<int> lostSnowmen = new List<int>();

                for (int i = 0; i < snowmen.Count; i++)
                {
                    if (lostSnowmen.Contains(i))
                    {
                        continue;
                    }

                    if (lostSnowmen.Count == snowmen.Count - 1)
                    {
                        break;
                    }

                    int attackerIndex = i;
                    int targetIndex = snowmen[attackerIndex];

                    if (targetIndex > snowmen.Count - 1)
                    {
                        targetIndex %= snowmen.Count;
                        snowmen[attackerIndex] = targetIndex;
                    }

                    if (attackerIndex == targetIndex)
                    {
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                        lostSnowmen.Add(attackerIndex);
                        continue;
                    }

                    if (Math.Abs(attackerIndex - targetIndex) % 2 == 0)
                    {
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                        lostSnowmen.Add(targetIndex);

                        if (lostSnowmen.Contains(attackerIndex))
                        {
                            lostSnowmen.Remove(attackerIndex);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                        lostSnowmen.Add(attackerIndex);

                        if (lostSnowmen.Contains(targetIndex))
                        {
                            lostSnowmen.Remove(targetIndex);
                        }
                    }
                }

                foreach (var snowman in lostSnowmen.OrderByDescending(x => x))
                {
                    snowmen.RemoveAt(snowman);
                }
            }
        }
    }
}
