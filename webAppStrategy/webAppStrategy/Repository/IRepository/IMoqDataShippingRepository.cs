using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using webAppStrategy.Models;

namespace webAppStrategy.Repository.IRepository
{
    public interface IMoqDataShippingRepository
    {
        public List<Shipping> GetShippingMethods();
    }
}
