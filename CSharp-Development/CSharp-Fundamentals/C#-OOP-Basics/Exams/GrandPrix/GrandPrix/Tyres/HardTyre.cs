using System;
using System.Collections.Generic;
using System.Text;


public class HardTyre : Tyre
{
    public override string Name => "Hard";
    public HardTyre(double hardness) : base(hardness)
    {
    }
}

