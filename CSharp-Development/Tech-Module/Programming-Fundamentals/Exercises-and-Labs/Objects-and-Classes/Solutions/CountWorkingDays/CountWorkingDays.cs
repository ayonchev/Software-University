using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            string startingDate = Console.ReadLine();
            string endingDate = Console.ReadLine();

            var startingDateInFormat = DateTime.ParseExact(startingDate,
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            var endingDateInFormat = DateTime.ParseExact(endingDate,
                "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            int workingDays = 0;

            for (DateTime currentDate = startingDateInFormat; currentDate <= endingDateInFormat; currentDate = currentDate.AddDays(1))
            {
                int year = currentDate.Year;

                DateTime[] holidays = new DateTime[]
            {
                new DateTime(year, 1, 1),
                new DateTime(year, 3, 3),
                new DateTime(year, 5, 1),
                new DateTime(year, 5, 6),
                new DateTime(year, 5, 24),
                new DateTime(year, 9, 6),
                new DateTime(year, 9, 22),
                new DateTime(year, 11, 1),
                new DateTime(year, 12, 24),
                new DateTime(year, 12, 25),
                new DateTime(year, 12, 26),
            };

                if (!holidays.Contains(currentDate) && currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
