using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Contracts
{
    public interface ILogFile
    {
        int Size { get; }

        void Write(string text);
    }
}
