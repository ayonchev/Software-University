using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class SlicingFile
{
    public static List<string> files = new List<string>();
    public static MatchCollection matches;
    public static void Main()
    {
        string inputFile = @"../sliceMe.mp4";
        string folderPath = @"";
        int NumberOfParts = int.Parse(Console.ReadLine());

        Slice(inputFile, folderPath, NumberOfParts);

        Assemble(files, folderPath);
    }

    public static void Assemble(List<string> files, string destinationDirectory)
    {
        string fileOutputPath = destinationDirectory + "assembled" + "." + matches[0].Groups[2];
        var fsSource = new FileStream(fileOutputPath, FileMode.Create);

        fsSource.Close();
        using (fsSource = new FileStream(fileOutputPath, FileMode.Append))
        {
            foreach (var filePart in files)
            {
                using (var partSource = new FileStream(filePart, FileMode.Open))
                {
                    Byte[] bytePart = new byte[4096];
                    while (true)
                    {
                        int readBytes = partSource.Read(bytePart, 0, bytePart.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        fsSource.Write(bytePart, 0, readBytes);
                    }
                }
            }
        }
    }

    public static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (var source = new FileStream(sourceFile, FileMode.Open))
        {
            long partSize = (long)Math.Ceiling((double)source.Length / parts);

            long fileOffset = 0;
            
            string currPartPath;
            FileStream fsPart;
            long sizeRemaining = source.Length;

            string pattern = @"(\w+)(?=\.)\.(?<=\.)(\w+)";
            Regex pairs = new Regex(pattern);
            matches = pairs.Matches(sourceFile);
            for (int i = 0; i < parts; i++)
            {
                currPartPath = destinationDirectory + String.Format(@"Part-{0}", i) + "." + matches[0].Groups[2];
                files.Add(currPartPath);

                using (fsPart = new FileStream(currPartPath, FileMode.Create))
                {
                    long currentPieceSize = 0;
                    byte[] buffer = new byte[4096];
                    while (currentPieceSize < partSize)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }


                        fsPart.Write(buffer, 0, readBytes);
                        currentPieceSize += readBytes;
                    }
                }

                sizeRemaining = (int)source.Length - (i * partSize);
                if (sizeRemaining < partSize)
                {
                    partSize = sizeRemaining;
                }
                fileOffset += partSize;
            }
        }
    }
}