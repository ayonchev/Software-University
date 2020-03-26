using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data
{
    class Configuration
    {
        internal static string ConnectionString => @"Server =.\SQLEXPRESS; Database = BillsPaymentSystem; Integrated Security = True;";
    }
}
