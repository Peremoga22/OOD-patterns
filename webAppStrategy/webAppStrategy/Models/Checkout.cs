using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAppStrategy.Models
{
    public class Checkout
    {
        public int SelectedMethod { get; set; }
        public decimal OrderTotal { get; set; }
        public decimal FinalTotal { get; set; }

        public List<Shipping> ShippingMethods { get; set; }
    }
}
