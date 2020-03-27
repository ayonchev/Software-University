using System;
using System.Collections.Generic;

public class ShoppingSpree
{
    static void Main()
    {
        string[] allPeople = Console.ReadLine().Split(new char[] { '=', ';' });
        string[] allProducts = Console.ReadLine().Split(new char[] { '=', ';' });

        try
        {
            List<Person> people = AddPeople(allPeople);
            List<Product> products = AddProducts(allProducts);

            AddToBag(people, products);

            people.ForEach(p => Console.WriteLine(p));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void AddToBag(List<Person> people, List<Product> products)
    {
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string personName = command.Split()[0];
            string productName = command.Split()[1];

            Person currentPerson = people.Find(p => p.Name == personName);
            Product currentProduct = products.Find(p => p.Name == productName);

            currentPerson.BuyProduct(currentProduct);
        }
    }

    static List<Product> AddProducts(string[] allProducts)
    {
        List<Product> products = new List<Product>();
        for (int index = 0; index < allProducts.Length; index += 2)
        {
            string name = allProducts[index];
            decimal cost = decimal.Parse(allProducts[index + 1]);

            products.Add(new Product(name, cost));
        }
        return products;
    }

    static List<Person> AddPeople(string[] allPeople)
    {
        List<Person> people = new List<Person>();
        for (int index = 0; index < allPeople.Length; index += 2)
        {
            string name = allPeople[index];
            decimal money = decimal.Parse(allPeople[index + 1]);

            people.Add(new Person(name, money));
        }
        return people;
    }
}

