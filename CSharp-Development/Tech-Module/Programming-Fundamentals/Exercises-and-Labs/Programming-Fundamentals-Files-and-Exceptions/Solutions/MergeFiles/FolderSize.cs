using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
    class FolderSize
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (var file in files)
            {
                FileInfo currFile = new FileInfo(file);
                sum += currFile.Length;
            }

            sum = sum / 1024 / 1024;
            File.WriteAllText("Output.txt", sum.ToString());
        }
    }
}
