using System;
using System.Collections.Generic;
using System.Text;

interface ICar
{
    string Model { get; set; }
    string DriverName { get; set; }
    string PushBrakes();
    string PushGas();
}
