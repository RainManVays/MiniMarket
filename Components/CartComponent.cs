using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using MiniMarket.Context;
using MiniMarket.Controllers;
using MiniMarket.Extensions;
using MiniMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MiniMarket.Components
{
    public class CartComponent : ViewComponent
    {

        public CartComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Order = HttpContext.Session.Get<Order>("order");
            ViewBag.OrderSumm = new OrderController().Summary(ViewBag.Order);
            return View("CartBlock");
        }

    }
}

