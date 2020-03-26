using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            string result = "";

            if (input == 'e' || input == 'i' || input == 'u' || input == 'o' || input == 'a')
            {
                result = "vowel";
            }
            else if ((int)input >= 48 && (int)input < 58)
            {
                result = "digit";
            }
            else
            {
                result = "other";
            }
            Console.WriteLine(result);
        }
    }
}
