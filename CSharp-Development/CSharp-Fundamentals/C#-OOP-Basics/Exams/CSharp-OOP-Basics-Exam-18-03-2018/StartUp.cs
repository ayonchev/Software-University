using System;
using System.Linq;

namespace DungeonsAndCodeWizards
{
    public class StartUp
    {
        // DO NOT rename this file's namespace or class name.
        // However, you ARE allowed to use your own namespaces (or no namespaces at all if you prefer) in other classes.
        public static void Main(string[] args)
        {
            DungeonMaster game = new DungeonMaster();
            string inputLine;
            while ((inputLine = Console.ReadLine()) != null && inputLine != string.Empty && game.IsOver == false)
            {
                try
                {
                    string[] arguments = inputLine.Split();
                    string commandType = arguments[0];

                    arguments = arguments.Skip(1).ToArray();
                    switch (commandType)
                    {
                        case "JoinParty":
                            Console.WriteLine(game.JoinParty(arguments));
                            break;
                        case "AddItemToPool":
                            Console.WriteLine(game.AddItemToPool(arguments));
                            break;
                        case "PickUpItem":
                            Console.WriteLine(game.PickUpItem(arguments));
                            break;
                        case "UseItem":
                            Console.WriteLine(game.UseItem(arguments));
                            break;
                        case "UseItemOn":
                            Console.WriteLine(game.UseItemOn(arguments));
                            break;
                        case "GiveCharacterItem":
                            Console.WriteLine(game.GiveCharacterItem(arguments));
                            break;
                        case "GetStats":
                            Console.Write(game.GetStats());
                            break;
                        case "Attack":
                            Console.WriteLine(game.Attack(arguments));
                            break;
                        case "Heal":
                            Console.WriteLine(game.Heal(arguments));
                            break;
                        case "EndTurn":
                            Console.Write(game.EndTurn(arguments));
                            break;
                        case "IsGameOver":
                            Console.WriteLine(game.IsGameOver());
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Parameter Error: " + ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Invalid Operation: " + ex.Message);
                }

                if (game.IsOver)
                {
                    break;
                }
            }

            Console.WriteLine("Final stats:");
            Console.Write(game.GetStats());
        }
    }
}