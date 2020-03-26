using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace SoftuniCoffeeOrders
{
    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0.0m;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime
                    .ParseExact(Console.ReadLine(),
                    "d/M/yyyy",
                    CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());

                decimal currentPrice = (DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * pricePerCapsule) * capsulesCount;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
                totalPrice += currentPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
