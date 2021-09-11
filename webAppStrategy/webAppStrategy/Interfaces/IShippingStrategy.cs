using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAppStrategy.Interfaces
{
    public  interface IShippingStrategy
    {
        decimal CalculateFinalTotal(decimal orderTotal);
    }
}
