using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Contracts;

namespace SOLID.Entities.Layouts
{
    public class SimpleLayout : ILayout
    {
        private string layout = "{0} - {1} - {2}";
        public string FormatError(IError error)
        {
            return String.Format(layout, error.Date, error.Level, error.Message);
        }
    }
}
