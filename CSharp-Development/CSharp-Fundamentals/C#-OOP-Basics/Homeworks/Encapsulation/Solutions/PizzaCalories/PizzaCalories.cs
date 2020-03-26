using System;

public class PizzaCalories
{
    static void Main()
    {
        try
        {
            string[] pizzaData = Console.ReadLine().Split();
            Pizza resultPizza = new Pizza(pizzaData[1]);

            string[] doughData = Console.ReadLine().Split();
            Dough newDough = new Dough(doughData[1], doughData[2], double.Parse(doughData[3]));
            resultPizza.Dough = newDough;

            AddToppings(resultPizza);

            Console.WriteLine(resultPizza);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }    
    }

    static void AddToppings(Pizza resultPizza)
    {
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] toppingData = command.Split();
            Topping newTopping = new Topping(toppingData[1], double.Parse(toppingData[2]));
            resultPizza.AddTopping(newTopping);
        }
    }
}
