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
        private readonly AddressContext _addressContext;

        public OrdersController(OrderContext orderContext,AddressContext addressContext)
        {
            _orderContext = orderContext;
            _addressContext = addressContext;
        }
        public IActionResult Index()
        {
            var orders = _orderContext.Orders.OrderBy(x => x.Id);
            List<Order> orderList = new List<Order>();
            foreach(var orderItem in orders)
            {
              orderList.Add(new Order(orderItem, _addressContext));
            }
            return View(orderList);
        }
        public IActionResult ChangeStatus()
        {
            return View();
        }
    }
}