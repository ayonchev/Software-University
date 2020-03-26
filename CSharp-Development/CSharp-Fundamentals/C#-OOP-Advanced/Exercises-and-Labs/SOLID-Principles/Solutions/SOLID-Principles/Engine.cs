using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logger.Entities.Appenders;
using Logger.Factories;
using SOLID.Contracts;

namespace LoggerExercise
{
    public class Engine
    {
        public void Start()
        {
            ILogger logger = InitializeLogger();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                logger.LogError(input);
            }

            Console.WriteLine(logger);
        }

        private static ILogger InitializeLogger()
        {
            int numberOfAppenders = int.Parse(Console.ReadLine());
            AppenderFactory appenderFactory = new AppenderFactory();
            List<IAppender> appenders = new List<IAppender>();

            for (int appenderIndex = 0; appenderIndex < numberOfAppenders; appenderIndex++)
            {
                string currentAppenderDetails = Console.ReadLine();
                int fileNumber = appenders.Where(a => a is FileAppender).Count() + 1;
                appenders.Add(appenderFactory.CreateAppender(currentAppenderDetails, fileNumber));
            }

            return new Logger.Entities.Logger(appenders);
        }
    }
}
