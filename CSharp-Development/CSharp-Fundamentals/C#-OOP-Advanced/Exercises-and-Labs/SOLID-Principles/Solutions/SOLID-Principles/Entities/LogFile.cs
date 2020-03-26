using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Logger.Contracts;

namespace Logger.Entities
{
    public class LogFile : ILogFile
    {
        private string Path = @"log-{0}.txt";

        public LogFile(int fileNumber)
        {
            Path = String.Format(Path, fileNumber);
        }

        public int Size => File.ReadAllText(Path).Where(l => Char.IsLetter(l)).Sum(l => l);

        public void Write(string text)
        {
            File.AppendAllText(Path, text + Environment.NewLine);
        }
    }
}
