using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAvg
{
    class SumMinMaxAvg
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] inputArray = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                inputArray[i] = currNum;
            }

            var result = new Dictionary<string, double>();
            result["Sum"] = inputArray.Sum();
            result["Min"] = inputArray.Min();
            result["Max"] = inputArray.Max();
            result["Average"] = inputArray.Average();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}
