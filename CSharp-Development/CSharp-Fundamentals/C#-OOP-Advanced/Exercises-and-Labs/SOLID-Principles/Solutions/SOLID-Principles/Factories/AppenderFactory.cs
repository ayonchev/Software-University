using System;
using System.Collections.Generic;
using System.Text;
using Logger.Entities;
using Logger.Entities.Appenders;
using SOLID.Contracts;

namespace Logger.Factories
{
    public class AppenderFactory
    {
        public IAppender CreateAppender(string appenderDetails, int fileNumber)
        {
            string[] appenderData = appenderDetails.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string appenderType = appenderData[0];
            LayoutFactory factory = new LayoutFactory();
            ILayout layout = factory.CreateLayout(appenderData[1]);
            ErrorLevel level = ErrorLevel.INFO;

            if (appenderData.Length == 3)
                level = (ErrorLevel)Enum.Parse(typeof(ErrorLevel), appenderData[2]);

            switch (appenderType.ToLower())
            {
                case "consoleappender":
                    return new ConsoleAppender(layout, level);
                case "fileappender":
                    return new FileAppender(layout, level, fileNumber);
                default:
                    throw new ArgumentException("No such appender was found!");
            }
        }
    }
}
