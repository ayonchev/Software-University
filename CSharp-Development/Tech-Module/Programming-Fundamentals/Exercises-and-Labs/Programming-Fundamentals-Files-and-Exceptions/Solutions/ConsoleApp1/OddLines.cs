using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OddLines
    {
        static void Main(string[] args)
        {
            var currentFile = File.ReadAllLines("Input.txt");
            List<string> result = new List<string>();

            for (int i = 0; i < currentFile.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(currentFile[i]);
                }
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}
