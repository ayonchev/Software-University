namespace CaloriesCounter
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var numOfIngredients = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < numOfIngredients; i++)
            {
                var ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        sum += 500;
                        break;
                    case "tomato sauce":
                        sum += 150;
                        break;
                    case "salami":
                        sum += 600;
                        break;
                    case "pepper":
                        sum += 50;
                        break;
                }
            }
            Console.WriteLine("Total calories: " + sum);
        }
    }
}
