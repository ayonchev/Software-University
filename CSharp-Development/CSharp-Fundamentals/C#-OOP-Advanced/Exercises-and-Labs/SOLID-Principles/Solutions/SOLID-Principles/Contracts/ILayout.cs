using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Contracts
{
    public interface ILayout
    {
        string FormatError(IError error);
    }
}
