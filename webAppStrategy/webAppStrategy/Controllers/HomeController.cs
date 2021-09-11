using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using webAppStrategy.Interfaces;
using webAppStrategy.Models;
using webAppStrategy.Repository.IRepository;
using webAppStrategy.Services;

namespace webAppStrategy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMoqDataOrderRepository _repoOrder;
        private readonly IShippingContext _shippingContext;
        private readonly IMoqDataShippingRepository _repoShipment;
        public HomeController(ILogger<HomeController> logger, IMoqDataOrderRepository _repoOrder, 
                               IShippingContext _shippingContext, IMoqDataShippingRepository _repoShipment)
        {
            _logger = logger;
            this._repoOrder = _repoOrder;
            this._shippingContext = _shippingContext;
            this._repoShipment = _repoShipment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _repoOrder.GetOrderDetails();

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Checkout model)
        {
            model.ShippingMethods = _repoShipment.GetShippingMethods();

            switch(model.SelectedMethod)
            {
                case 1:
                    _shippingContext.SetStrategy(new FreeShippingStrategyService());
                    break;

                case 2:
                    _shippingContext.SetStrategy(new LocalShippingStrategyService());
                    break;
                case 3:
                    _shippingContext.SetStrategy(new WorldwideShippingStrategyService());
                    break;
            }

            model.FinalTotal = _shippingContext.ExecuteStrategy(model.OrderTotal);

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
