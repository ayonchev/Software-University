using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExWords2Variant
{
    class MagicExchWordsSecondVariant
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string firstWord = input[0];
            string secondWord = input[1];

            var firstArr = firstWord.ToCharArray().Distinct().ToArray();
            var secondArr = secondWord.ToCharArray().Distinct().ToArray();

            if (firstArr.Length == secondArr.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            ь
        }
    }
}
