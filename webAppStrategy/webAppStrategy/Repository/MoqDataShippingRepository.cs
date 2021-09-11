using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using webAppStrategy.Models;
using webAppStrategy.Repository.IRepository;

namespace webAppStrategy.Repository
{
    public class MoqDataShippingRepository : IMoqDataShippingRepository
    {
        public List<Shipping> GetShippingMethods()
        {
            return new List<Shipping>()
            {
               new Shipping()
               {
                   Id = 1,
                   Name ="Free shipping ($0.00)"
               },
               new Shipping()
               {
                   Id = 2,
                   Name ="Local Shipping ($10.00)"
               },
               new Shipping()
               {
                    Id = 3,
                    Name="Worldwide Shipping ($50.00)"
               }
            };
        }
    }
}
