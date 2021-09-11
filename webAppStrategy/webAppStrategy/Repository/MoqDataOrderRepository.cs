using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using webAppStrategy.Models;
using webAppStrategy.Repository.IRepository;

namespace webAppStrategy.Repository
{
    public class MoqDataOrderRepository : IMoqDataOrderRepository
    {
        private readonly IMoqDataShippingRepository _repo;
     
        public MoqDataOrderRepository(IMoqDataShippingRepository _repo)
        {
            this._repo = _repo;
        }

        public Checkout GetOrderDetails()
        {
            var model = new Checkout()
            {
                OrderTotal = 100.00m,
                ShippingMethods = _repo.GetShippingMethods()
            };

          return model;
        }
    }
}
