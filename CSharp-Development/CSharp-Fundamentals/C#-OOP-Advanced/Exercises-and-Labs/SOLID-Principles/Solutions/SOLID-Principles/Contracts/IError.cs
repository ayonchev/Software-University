using System;
using System.Collections.Generic;
using System.Text;
using Logger.Entities;

namespace SOLID.Contracts
{
    public interface IError
    {
        ErrorLevel Level { get; }
        DateTime Date { get; }
        string Message { get; }
    }
}
