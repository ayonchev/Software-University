using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    public class Sale
    {
        public string Town { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Sum => Quantity * Price;
    }
}
