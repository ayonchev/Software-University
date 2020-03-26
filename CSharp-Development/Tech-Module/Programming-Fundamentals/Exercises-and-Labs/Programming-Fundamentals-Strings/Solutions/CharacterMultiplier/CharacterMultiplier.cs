using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ');

            string firstWord = inputArray[0];
            string secondWord = inputArray[1];

            string shorterWord = "";
            string longerWord = "";

            if (firstWord.Length > secondWord.Length)
            {
                longerWord = firstWord;
                shorterWord = secondWord;
            }
            else
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }

            int sum = 0;

            for (int i = 0; i < longerWord.Length; i++)
            {
                if (i < shorterWord.Length)
                {
                    sum += longerWord[i] * shorterWord[i];
                }
                else
                {
                    sum += longerWord[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
