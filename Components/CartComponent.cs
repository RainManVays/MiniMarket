using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Extensions;
using MiniMarket.Infrastructure;
using MiniMarket.Models;

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
            ViewBag.OrderSumm = new OrderWorker().Summary(ViewBag.Order);
            return View("CartBlock");
        }

    }
}

