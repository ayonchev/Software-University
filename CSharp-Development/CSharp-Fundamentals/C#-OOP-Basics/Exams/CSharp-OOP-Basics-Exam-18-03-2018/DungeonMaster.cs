using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DungeonMaster
{
    private List<Character> allCharacters;
    private List<Item> itemPool;
    private int lastSurvivorRounds;
    public bool IsOver { get; private set; }

    public DungeonMaster()
    {
        allCharacters = new List<Character>();
        itemPool = new List<Item>();
        lastSurvivorRounds = 0;
        IsOver = false;
    }

    public string JoinParty(string[] args)
    {
        string faction = args[0];
        string characterType = args[1];
        string name = args[2];

        CharacterFactory factory = new CharacterFactory();
        Character currentCharacter = factory.CreateCharacter(faction, characterType, name);

        allCharacters.Add(currentCharacter);
        return $"{currentCharacter.Name} joined the party!";
    }

    public string AddItemToPool(string[] args)
    {
        string itemName = args[0];

        ItemFactory factory = new ItemFactory();
        Item currentItem = factory.CreateItem(itemName);

        itemPool.Add(currentItem);
        return $"{currentItem.Name} added to pool.";
    }

    public string PickUpItem(string[] args)
    {
        string characterName = args[0];

        CheckExistence(characterName);

        if (itemPool.Count == 0)
        {
            throw new InvalidOperationException($"No items left in pool!");
        }

        var currentCharacter = allCharacters.FirstOrDefault(c => c.Name == characterName);
        var currentItem = itemPool[itemPool.Count - 1];
        currentCharacter.ReceiveItem(currentItem);

        itemPool.Remove(currentItem);

        return $"{currentCharacter.Name} picked up {currentItem.Name}!";
    }

    public string UseItem(string[] args)
    {
        string characterName = args[0];
        string itemName = args[1];

        CheckExistence(characterName);
        var currentCharacter = allCharacters.FirstOrDefault(c => c.Name == characterName);
        Item currentItem = currentCharacter.Bag.GetItem(itemName);
        currentCharacter.UseItem(currentItem);

        return $"{currentCharacter.Name} used {currentItem.Name}.";
    }

    public string UseItemOn(string[] args)
    {
        string giverName = args[0];
        string receiverName = args[1];
        string itemName = args[2];

        CheckExistence(giverName);
        CheckExistence(receiverName);
        var giver = allCharacters.FirstOrDefault(c => c.Name == giverName);
        var receiver = allCharacters.FirstOrDefault(c => c.Name == receiverName);
        Item currentItem = giver.Bag.GetItem(itemName);
        giver.UseItemOn(currentItem, receiver);

        return $"{giverName} used {itemName} on {receiverName}.";
    }

    public string GiveCharacterItem(string[] args)
    {
        string giverName = args[0];
        string receiverName = args[1];
        string itemName = args[2];

        CheckExistence(giverName);
        CheckExistence(receiverName);
        var giver = allCharacters.FirstOrDefault(c => c.Name == giverName);
        var receiver = allCharacters.FirstOrDefault(c => c.Name == receiverName);
        Item currentItem = giver.Bag.GetItem(itemName);
        giver.GiveCharacterItem(currentItem, receiver);

        return $"{giverName} gave {receiverName} {itemName}.";
    }

    public string GetStats()
    {
        string result = string.Empty;

        foreach (var character in allCharacters.OrderByDescending(c => c.IsAlive).ThenByDescending(c => c.Health))
        {
            string status = string.Empty;

            if (character.IsAlive)
            {
                status = "Alive";
            }
            else
            {
                status = "Dead";
            }

            result +=
                $"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {status}" +
                Environment.NewLine;
        }

        return result;
    }

    public string Attack(string[] args)
    {
        string attackerName = args[0];
        string receiverName = args[1];

        CheckExistence(attackerName);
        CheckExistence(receiverName);

        var attacker = allCharacters.FirstOrDefault(c => c.Name == attackerName);
        var receiver = allCharacters.FirstOrDefault(c => c.Name == receiverName);

        if (!(attacker is Warrior))
        {
            throw new ArgumentException($"{attacker.Name} cannot attack!");
        }

        Warrior attackerWarrior = (Warrior)attacker;

        attackerWarrior.Attack(receiver);

        string result =
            $"{attackerName} attacks {receiverName} for {attackerWarrior.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!";

        if (!receiver.IsAlive)
        {
            result += Environment.NewLine + $"{receiver.Name} is dead!";
        }

        return result;
    }

    public string Heal(string[] args)
    {
        string healerName = args[0];
        string healingReceiverName = args[1];

        CheckExistence(healerName);
        CheckExistence(healingReceiverName);

        var healerCharacter = allCharacters.FirstOrDefault(c => c.Name == healerName);
        var healingReceiver = allCharacters.FirstOrDefault(c => c.Name == healingReceiverName);

        if (!(healerCharacter is Cleric))
        {
            throw new ArgumentException($"{healerName} cannot heal!");
        }

        Cleric healer = (Cleric)healerCharacter;

        healer.Heal(healingReceiver);

        return
            $"{healer.Name} heals {healingReceiver.Name} for {healer.AbilityPoints}! {healingReceiver.Name} has {healingReceiver.Health} health now!";
    }

    public string EndTurn(string[] args)
    {
        string result = String.Empty;

        if (allCharacters.Where(c => c.IsAlive).Count() <= 1)
        {
            lastSurvivorRounds++;
        }

        foreach (var character in allCharacters.Where(c => c.IsAlive))
        {
            double healthBeforeRest = character.Health;
            character.Rest();
            result += $"{character.Name} rests ({healthBeforeRest} => {character.Health})" + Environment.NewLine;
        }

        IsGameOver();

        return result;
    }

    public bool IsGameOver()
    {
        if (lastSurvivorRounds > 1)
        {
            IsOver = true;
        }

        return IsOver;
    }

    public void CheckExistence(string characterName)
    {
        if (!allCharacters.Any(c => c.Name == characterName))
        {
            throw new ArgumentException($"Character {characterName} not found!");
        }
    }
}
