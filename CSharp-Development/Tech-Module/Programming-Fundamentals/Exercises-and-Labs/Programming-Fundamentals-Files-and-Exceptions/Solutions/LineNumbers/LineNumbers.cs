using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            var currentFile = File.ReadAllLines("Input.txt");
            string[] result = new string[currentFile.Length];

            for (int i = 0; i < currentFile.Length; i++)
            {
                result[i] = $"{i + 1}. " + currentFile[i];
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}
