using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Context;
using MiniMarket.Models;

namespace MiniMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class OrdersController : Controller
    {
        private OrderContext _orderContext;

        public OrdersController(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }
        public IActionResult Index()
        {
            var orders = _orderContext.Orders.OrderBy(x => x.Id);
            Order order = new Order();
            return View(orders);
        }
    }
}