using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using webAppStrategy.Interfaces;

namespace webAppStrategy.Services
{
    public class WorldwideShippingStrategyService : IShippingStrategy
    {
        public decimal CalculateFinalTotal(decimal orderTotal)
        {
            return orderTotal + 50;
        }
    }
}
