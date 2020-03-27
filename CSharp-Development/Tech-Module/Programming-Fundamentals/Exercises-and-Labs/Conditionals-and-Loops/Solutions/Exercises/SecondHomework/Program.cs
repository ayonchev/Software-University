namespace SecondHomework
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var price = 0.0;

            if (profession == "Athlete")
            {
                price = 0.7;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1.0;   
            }
            else if (profession == "SoftUni Student")
            {
                price = 1.7;   
            }
            else
            {
                price = 1.2;
            }
            Console.WriteLine($"The {profession} has to pay {(price * quantity):F2}.");
        }
    }
}
