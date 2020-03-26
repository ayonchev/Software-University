using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            string upperSurface = Console.ReadLine();
            string upperMantle = Console.ReadLine();
            string coreInput = Console.ReadLine();
            string lowerMantle = Console.ReadLine();
            string lowerSurface = Console.ReadLine();


            string surfacePattern = @"^[^0-9a-zA-Z]+$";
            string mantlePattern = @"^[0-9_]+$";
            string corePattern = @"^[^0-9a-zA-Z]+[0-9_]+([a-zA-Z]+)[0-9_]+[^0-9a-zA-Z]+$";

            bool isValid = true;

            if (Regex.IsMatch(upperSurface, surfacePattern) && Regex.IsMatch(upperMantle, mantlePattern) && Regex.IsMatch(coreInput, corePattern) && Regex.IsMatch(lowerMantle, mantlePattern) && Regex.IsMatch(lowerSurface, surfacePattern))
            {
                string core = Regex.Match(coreInput, corePattern).Groups[1].Value;
                
                Console.WriteLine("Valid");
                Console.WriteLine(core.Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
