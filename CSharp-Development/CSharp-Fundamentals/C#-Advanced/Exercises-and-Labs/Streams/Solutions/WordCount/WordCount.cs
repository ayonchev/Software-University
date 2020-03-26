using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            StreamReader reader;
            using (reader = new StreamReader("words.txt"))
            {
                Dictionary<string, int> words = new Dictionary<string, int>();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    words[line] = 0;
                }

                using (reader = new StreamReader("text.txt"))
                {
                    string text = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        text += line;
                    }

                    using (var writer = new StreamWriter("result.txt"))
                    {
                        string[] textInWords = text.Split(new char[] { ' ', '-', '!', '?', '.', ',' },
                            StringSplitOptions.RemoveEmptyEntries);

                        for (int word = 0; word < textInWords.Length; word++)
                        {
                            if (words.ContainsKey(textInWords[word].ToLower()))
                            {
                                words[(textInWords[word]).ToLower()]++;
                            }
                        }

                        foreach (var word in words.OrderByDescending(x => x.Value))
                        {
                            writer.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                }
            }
        }
    }
}
