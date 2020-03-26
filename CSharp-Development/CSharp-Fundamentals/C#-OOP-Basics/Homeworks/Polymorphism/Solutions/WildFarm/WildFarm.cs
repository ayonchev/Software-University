using System;
using System.Collections.Generic;

public class WildFarm
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>();

        ExecuteCommands(animals);

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    static void ExecuteCommands(List<Animal> animals)
    {
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            try
            {
                string[] animalData = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Animal newAnimal = CreateAnimal(animalData);
                newAnimal.AskForFood();

                string[] foodData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Food currentFood = GetFood(foodData);

                animals.Add(newAnimal);
                newAnimal.Feed(currentFood);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    static Food GetFood(string[] foodData)
    {
        string foodType = foodData[0];
        int quantity = int.Parse(foodData[1]);

        Food currentFood = null;

        switch (foodType)
        {
            case "Fruit":
                currentFood = new Fruit(quantity);
                break;
            case "Meat":
                currentFood = new Meat(quantity);
                break;
            case "Seeds":
                currentFood = new Seeds(quantity);
                break;
            case "Vegetable":
                currentFood = new Vegetable(quantity);
                break;
        }

        return currentFood;
    }
    static Animal CreateAnimal(string[] animalData)
    {
        string animalType = animalData[0];
        string animalName = animalData[1];
        double animalWeight = double.Parse(animalData[2]);

        Animal newAnimal = null;

        switch (animalType)
        {
            case "Hen":
                newAnimal = new Hen(animalName, animalWeight, double.Parse(animalData[3]));
                break;
            case "Owl":
                newAnimal = new Owl(animalName, animalWeight, double.Parse(animalData[3]));
                break;
            case "Cat":
                newAnimal = new Cat(animalName, animalWeight, animalData[3], animalData[4]);
                break;
            case "Tiger":
                newAnimal = new Tiger(animalName, animalWeight, animalData[3], animalData[4]);
                break;
            case "Dog":
                newAnimal = new Dog(animalName, animalWeight, animalData[3]);
                break;
            case "Mouse":
                newAnimal = new Mouse(animalName, animalWeight, animalData[3]);
                break;
        }

        return newAnimal;
    }
}
