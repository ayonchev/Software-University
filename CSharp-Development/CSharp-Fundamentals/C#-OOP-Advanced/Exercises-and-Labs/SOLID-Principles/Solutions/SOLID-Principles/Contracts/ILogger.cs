using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Contracts
{
    public interface ILogger
    {
        ICollection<IAppender> Appenders { get; }

        void LogError(string message);
    }
}
