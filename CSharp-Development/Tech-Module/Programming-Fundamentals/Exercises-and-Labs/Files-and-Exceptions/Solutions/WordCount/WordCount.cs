using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText("words.txt").Split(' ');
            Dictionary<string, int> result = new Dictionary<string, int>();
            string resultText = "";

            for (int i = 0; i < words.Length; i++)
            {
                result.Add(words[i], 0);
            }

            var exampleFile = File
                .ReadAllText("text.txt")
                .ToLower()
                .Split(new char[] { ' ', ',', '!', '?', '.', '-', '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in exampleFile)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
            }

            foreach (var word in result.OrderByDescending(x => x.Value))
            {
                resultText += word.Key + " -> " + word.Value + Environment.NewLine;
            }

            File.WriteAllText("Output.txt", resultText);
        }
    }
}
