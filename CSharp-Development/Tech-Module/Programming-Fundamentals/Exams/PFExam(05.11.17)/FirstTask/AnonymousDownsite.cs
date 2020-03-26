using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FirstTask
{
    class AnonymousDownsite
    {
        static void Main(string[] args)
        {
            int numberOfWebsites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0.0m;
            BigInteger securityToken = 1;

            for (int i = 0; i < numberOfWebsites; i++)
            {
                string[] currentSite = Console.ReadLine()
                    .Split(new char[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);

                string siteName = currentSite[0];
                long siteVisits = long.Parse(currentSite[1]);
                decimal pricePerVisit = decimal.Parse(currentSite[2]);

                totalLoss += siteVisits * pricePerVisit;
                Console.WriteLine(siteName);
            }

            for (int i = 0; i < numberOfWebsites; i++)
            {
                securityToken *= securityKey;
            }

            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
