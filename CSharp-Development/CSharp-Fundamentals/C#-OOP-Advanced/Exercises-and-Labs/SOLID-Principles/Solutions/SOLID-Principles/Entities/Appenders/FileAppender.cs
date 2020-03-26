using System;
using System.Collections.Generic;
using System.Text;
using Logger.Contracts;
using SOLID.Contracts;

namespace Logger.Entities.Appenders
{
    public class FileAppender : IAppender
    {
        public FileAppender(ILayout layout, ErrorLevel level, int fileNumber)
        {
            this.Layout = layout;
            this.Level = level;
            this.AppendedMessages = 0;
            this.File = new LogFile(fileNumber);
        }
        public ILayout Layout { get; }
        public ErrorLevel Level { get; }
        public int AppendedMessages { get; private set; }
        public ILogFile File { get; }
        public void AppendError(IError error)
        {
            if (error.Level >= this.Level)
            {
                File.Write(Layout.FormatError(error));
                AppendedMessages++;
            }
        }

        public override string ToString()
        {
            return
                $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level.ToString()}, Messages appended: {AppendedMessages}, File size {File.Size}";
        }
    }
}
