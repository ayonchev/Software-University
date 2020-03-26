using System;
using System.Collections.Generic;
using System.Linq;

class Google
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] currentPersonInfo = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = currentPersonInfo[0];
            string commandType = currentPersonInfo[1];

            Person currentPerson = new Person(name);
            if (people.Any(x => x.Name == name))
            {
                currentPerson = people.Where(x => x.Name == name).FirstOrDefault();

                currentPerson = ModifyPerson(currentPersonInfo, currentPerson);
            }
            else
            {
                currentPerson = ModifyPerson(currentPersonInfo, currentPerson);

                people.Add(currentPerson);
            }
        }

        string personName = Console.ReadLine();

        Person personToPrint = people.Where(x => x.Name == personName).FirstOrDefault();
        Console.WriteLine(personToPrint.ToString());
    }

    static Person ModifyPerson(string[] currentPersonInfo, Person currentPerson)
    {
        string command = currentPersonInfo[1];
        string firstInfo = currentPersonInfo[2];
        string secondInfo = currentPersonInfo[3];

        if (currentPersonInfo.Length == 4)
        {
            switch (command)
            {
                case "pokemon":
                    Pokemon newPokemon = new Pokemon(firstInfo, secondInfo);
                    currentPerson.Pokemons.Add(newPokemon);
                    break;
                case "parents":
                    Parent newParent = new Parent(firstInfo, secondInfo);
                    currentPerson.Parents.Add(newParent);
                    break;
                case "car":
                    Car newCar = new Car(firstInfo, double.Parse(secondInfo));
                    currentPerson.Car = newCar;
                    break;
                case "children":
                    Child newChild = new Child(firstInfo, secondInfo);
                    currentPerson.Children.Add(newChild);
                    break;
            }
        }
        else
        {
            Company newCompany = new Company(firstInfo, secondInfo, double.Parse(currentPersonInfo[4]));
            currentPerson.Company = newCompany;
        }

        return currentPerson;
    }
}
