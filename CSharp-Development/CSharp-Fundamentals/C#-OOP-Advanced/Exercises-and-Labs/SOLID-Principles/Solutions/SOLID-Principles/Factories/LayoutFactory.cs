using System;
using System.Collections.Generic;
using System.Text;
using Logger.Entities.Layouts;
using SOLID.Contracts;
using SOLID.Entities.Layouts;

namespace Logger.Factories
{
    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutType)
        {
            switch (layoutType.ToLower())
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();
                default:
                    throw new ArgumentException("No such layout was found!");
            }
        }
    }
}
