using System;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../text.txt"))
            {
                int lineNumber = 1;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"Line {lineNumber}: {line}");
                    lineNumber++;
                }
            }
        }
    }
}
