using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ');
            Random rnd = new Random();

            for (int i = 0; i < inputArray.Length; i++)
            {
                int randomIndex = rnd.Next(0, inputArray.Length - 1);
                string currentWord = inputArray[i];

                string temp = inputArray[randomIndex];
                inputArray[i] = temp;
                inputArray[randomIndex] = currentWord;
            }

            foreach (var word in inputArray)
            {
                Console.WriteLine(word);
            }
        }
    }
}
