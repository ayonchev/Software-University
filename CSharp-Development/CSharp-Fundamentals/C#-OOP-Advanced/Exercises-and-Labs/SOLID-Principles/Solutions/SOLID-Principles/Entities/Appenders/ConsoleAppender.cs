using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Contracts;

namespace Logger.Entities.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ErrorLevel level)
        {
            this.Layout = layout;
            this.Level = level;
            this.AppendedMessages = 0;
        }

        public ILayout Layout { get; }
        public ErrorLevel Level { get; }
        public int AppendedMessages { get; private set; }

        public void AppendError(IError error)
        {
            if (error.Level >= this.Level)
            {
                Console.WriteLine(Layout.FormatError(error));
                AppendedMessages++;
            }
        }

        public override string ToString()
        {
            return
                $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level.ToString()}, Messages appended: {AppendedMessages}";
        }
    }
}
