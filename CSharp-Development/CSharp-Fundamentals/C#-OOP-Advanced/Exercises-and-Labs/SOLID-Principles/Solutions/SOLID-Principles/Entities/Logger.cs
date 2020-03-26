using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logger.Factories;
using SOLID.Contracts;

namespace Logger.Entities
{
    public class Logger : ILogger
    {
        public Logger(ICollection<IAppender> appenders)
        {
            this.Appenders = appenders;
        }
        public ICollection<IAppender> Appenders { get; }
        public void LogError(string errorMessage)
        {
            ErrorFactory errorFactory = new ErrorFactory();
            IError error = errorFactory.CreateError(errorMessage);

            this.Appenders.ToList().ForEach(a => a.AppendError(error));
        }

        public override string ToString()
        {
            return "Logger info" + Environment.NewLine +
                string.Join(Environment.NewLine, Appenders);
        }
    }
}
