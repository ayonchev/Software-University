namespace NeighbourWars
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;

            var i = 1;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                if (i % 2 == 0) // Gosho attacks
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }   
                }

                else // Pesho attacks
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }  
                }

                if (i % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                i++;
            }

            if (peshoHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {i}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {i}th round.");
            }
        }
    }
}
