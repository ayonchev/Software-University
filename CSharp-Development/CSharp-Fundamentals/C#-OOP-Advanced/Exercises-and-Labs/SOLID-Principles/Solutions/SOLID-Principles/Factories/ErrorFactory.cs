using System;
using System.Collections.Generic;
using System.Text;
using Logger.Entities;
using SOLID.Contracts;

namespace Logger.Factories
{
    public class ErrorFactory
    {
        public IError CreateError(string errorMessage)
        {
            string[] errorData = errorMessage.Split('|');

            ErrorLevel level = (ErrorLevel)Enum.Parse(typeof(ErrorLevel), errorData[0]);
            DateTime date = DateTime.Parse(errorData[1]);
            string message = errorData[2];

            return new Error(level, date, message);
        }
    }
}
