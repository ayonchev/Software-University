using System;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../text.txt"))
            {
                int lineNumber = 0;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine($"Line {lineNumber}: {line}");
                    }
                    lineNumber++;
                }
            }
        }
    }
}
