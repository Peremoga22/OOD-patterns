using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using webAppStrategy.Models;

namespace webAppStrategy.Repository.IRepository
{
    public interface IMoqDataOrderRepository
    {
        public Checkout GetOrderDetails();
    }
}
