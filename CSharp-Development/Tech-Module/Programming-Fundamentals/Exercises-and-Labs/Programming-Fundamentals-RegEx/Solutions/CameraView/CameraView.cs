using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int elementsToSkip = data[0];
            int elementsToTake = data[1];

            string pattern = @"\|\<\w{" + elementsToSkip + @"}(\w{0," + elementsToTake + @"})";

            string input = Console.ReadLine();

            List<string> result = new List<string>();

            foreach (Match match in Regex.Matches(input, pattern))
            {
                result.Add(match.Groups[1].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
