using System;
using System.Collections.Generic;
using System.Text;

interface ILeutenantGeneral : IPrivate
{
    List<Private> privates { get; set; }
}
