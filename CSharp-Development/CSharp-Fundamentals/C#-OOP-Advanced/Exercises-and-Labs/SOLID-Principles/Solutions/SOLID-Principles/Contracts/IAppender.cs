using System;
using System.Collections.Generic;
using System.Text;
using Logger.Entities;

namespace SOLID.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        ErrorLevel Level { get; }

        int AppendedMessages { get; }

        void AppendError(IError error);
    }
}
