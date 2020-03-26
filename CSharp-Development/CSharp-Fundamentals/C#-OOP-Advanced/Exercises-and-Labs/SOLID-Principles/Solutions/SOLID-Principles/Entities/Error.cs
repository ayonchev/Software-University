using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Contracts;

namespace Logger.Entities
{
    public class Error : IError
    {
        public Error(ErrorLevel level, DateTime date, string message)
        {
            this.Level = level;
            this.Date = date;
            this.Message = message;
        }
        public ErrorLevel Level { get; }
        public DateTime Date { get; }
        public string Message { get; }
    }
}
