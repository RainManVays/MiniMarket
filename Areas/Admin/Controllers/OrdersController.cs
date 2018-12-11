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
        private  AddressContext _addressContext;
        private  ProductContext _productContext;
        private DeliveryAreaContext _deliveryAreaContext;

        public OrdersController(OrderContext orderContext,AddressContext addressContext, ProductContext productContext, DeliveryAreaContext deliveryAreaContext)
        {
            _orderContext = orderContext;
            _addressContext = addressContext;
            _productContext = productContext;
            _deliveryAreaContext = deliveryAreaContext;
        }
        public IActionResult Index()
        {
            var orders = _orderContext.Orders.OrderByDescending(x => x.Id);
            List<Order> orderList = new List<Order>();
            foreach(var orderItem in orders)
            {
                orderList.Add(new Order(orderItem, _addressContext, _productContext));
            }

            var areas = _deliveryAreaContext.DeliveryAreas.ToList();

            for (int i = 0; i < areas.Count; i++){
                ViewData[areas[i].Id.ToString()] = areas[i].Name;
            }
            
            return View(orderList);
        }
        public IActionResult ChangeStatus()
        {
            return View();
        }
        public string GetDeliveryAreaName(int id)
        {
            return new DeliveryArea().GetAreaNameFromId(id, _deliveryAreaContext);
        }
    }
}