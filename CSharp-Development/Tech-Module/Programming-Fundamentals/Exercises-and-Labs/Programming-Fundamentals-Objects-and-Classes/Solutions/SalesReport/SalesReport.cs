using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{   
    class SalesReport
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < count; i++)
            {
                string[] inputArray = Console.ReadLine().Split(' ');

                decimal currentPrice = decimal.Parse(inputArray[2]);
                decimal currentQuantity = decimal.Parse(inputArray[3]);
                string currentTown = inputArray[0];

                Sale currentTownSales = new Sale
                {
                    Town = currentTown,
                    Price = currentPrice,
                    Quantity = currentQuantity
                };

                if (!salesByTown.ContainsKey(currentTownSales.Town))
                {
                    salesByTown.Add(currentTown, currentTownSales.Sum);
                }
                else
                {
                    salesByTown[currentTown] += currentTownSales.Sum;
                }
            }

            foreach (var town in salesByTown)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:F2}");
            }
        }
    }
}
