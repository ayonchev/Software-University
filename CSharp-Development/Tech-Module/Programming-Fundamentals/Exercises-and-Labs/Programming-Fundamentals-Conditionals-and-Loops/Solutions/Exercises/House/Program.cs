
namespace House
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var numOfNights = int.Parse(Console.ReadLine());
            double doublePrice = 0;
            double suitePrice = 0;
            double studioPrice = 0;
            var studioNights = numOfNights;

            if (month == "May" || month == "October")
            {
                suitePrice = 75;
                doublePrice = 65;
                
                if (numOfNights > 7 && month != "October")
                {
                    studioPrice = 50 * 0.95;
                }
                else if (numOfNights > 7 && month == "October")
                {
                    studioNights--;
                    studioPrice = 50 * 0.95;
                }
                else
                {
                    studioPrice = 50;
                    
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                suitePrice = 82;
                if (numOfNights > 7)
                {
                    studioNights--;
                }

                if (numOfNights > 14)
                {
                    doublePrice = 72 * 0.9;
                }
                else
                {
                    doublePrice = 72;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                if (numOfNights > 14)
                {
                    suitePrice = 89 * 0.85;
                }
                else
                {
                    suitePrice = 89;
                }
            }

            Console.WriteLine($"Studio: {(studioPrice * studioNights):F2} lv.");
            Console.WriteLine($"Double: {(doublePrice * numOfNights):F2} lv.");
            Console.WriteLine($"Suite: {(suitePrice * numOfNights):F2} lv.");
        }
    }
}
