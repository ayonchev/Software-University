using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            var currentDate = DateTime.ParseExact(date,
                "d-M-yyyy",
                CultureInfo.InvariantCulture);
            Console.WriteLine(currentDate.DayOfWeek);
        }
    }
}
