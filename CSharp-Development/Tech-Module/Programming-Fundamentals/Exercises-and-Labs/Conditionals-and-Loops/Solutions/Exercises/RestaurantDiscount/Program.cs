namespace RestaurantDiscount
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var hall = "";
            var hallPrice = 0;
            var discountPrice = 0;
            var discount = 0.0;
            var sum = 0.0;

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                hallPrice = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                hallPrice = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                hallPrice = 7500;
            }
            

            if (package == "Normal")
            {
                discountPrice = 500;
                discount = 0.95;
            }
            else if (package == "Gold")
            {
                discountPrice = 750;
                discount = 0.90;
            }
            else
            {
                discountPrice = 1000;
                discount = 0.85;
            }

            sum = (discountPrice + hallPrice) * discount;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hall} \nThe price per person is {(sum / groupSize):F2}$");
            }
            
        }
    }
}
