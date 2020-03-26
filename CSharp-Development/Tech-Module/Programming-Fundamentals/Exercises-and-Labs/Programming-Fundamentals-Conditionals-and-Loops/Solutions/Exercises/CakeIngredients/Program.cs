namespace CakeIngredients
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var numberOfIngredients = 0;

            while (numberOfIngredients <= 20)
            {
                var ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    numberOfIngredients++;
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {numberOfIngredients} ingredients.");
                    break;
                }
            }
        }
    }
}
