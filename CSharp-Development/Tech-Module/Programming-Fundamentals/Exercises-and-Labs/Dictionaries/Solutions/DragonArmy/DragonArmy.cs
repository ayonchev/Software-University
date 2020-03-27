using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputArray = Console.ReadLine().Split(' ').ToArray();
                bool validInput = IsValid(inputArray);

                if (validInput == false)
                {

                }
                else
                {

                }
            }
        }

        static bool IsValid(string[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == "null")
                {
                    return false;
                }
            }
            return true;
        }
    }
}
