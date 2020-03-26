using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Contracts;

namespace Logger.Entities.Layouts
{
    public class XmlLayout : ILayout
    {
        private string layout = "<log>" + Environment.NewLine +
                                      "\t<date> {0} </date>" + Environment.NewLine +
                                      "\t<level> {1} </level> " + Environment.NewLine +
                                      "\t<message> {2} </message>" + Environment.NewLine +
                                      "</log>";

        public string FormatError(IError error)
        {
            return String.Format(layout, error.Date, error.Level, error.Message);
        }
    }
}
