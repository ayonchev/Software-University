using System;
using System.Collections.Generic;

public class Animals
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>();

        string type;
        while ((type = Console.ReadLine()) != "Beast!")
        {
            try
            {
                string[] animalData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                AddAnimal(type, animalData, animals);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        animals.ForEach(a => Console.WriteLine(a));
    }

    static void AddAnimal(string type, string[] animalData, List<Animal> animals)
    {
        string name = animalData[0];
        int age = int.Parse(animalData[1]);
        string gender = animalData[2];

        Animal currentAnimal = CreateAnimal(type, name, age, gender);

        animals.Add(currentAnimal);
    }

    static Animal CreateAnimal(string type, string name, int age, string gender)
    {
        Animal currentAnimal = null;

        switch (type.ToLower())
        {
            case "cat":
                currentAnimal = new Cat(name, age, gender);
                break;
            case "tomcat":
                currentAnimal = new Tomcat(name, age);
                break;
            case "kitten":
                currentAnimal = new Kitten(name, age);
                break;
            case "dog":
                currentAnimal = new Dog(name, age, gender);
                break;
            case "frog":
                currentAnimal = new Frog(name, age, gender);
                break;
            default:
                throw new ArgumentException("Invalid input!");
                break;
        }

        return currentAnimal;
    }
}
