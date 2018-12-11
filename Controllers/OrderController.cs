using Microsoft.AspNetCore.Mvc;
using MiniMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MiniMarket.Extensions;
using MiniMarket.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace MiniMarket.Controllers
{
    public class OrderController : Controller
    {

        ProductContext _productContext;
        DeliveryAreaContext _deliveryAreaContext;
        AddressContext _addressContext;
        OrderContext _orderContext;

        public OrderController(ProductContext productContext, DeliveryAreaContext deliveryAreaContext,AddressContext addressContext,OrderContext orderContext)
        {
            _productContext = productContext;
            _deliveryAreaContext = deliveryAreaContext;
            _addressContext = addressContext;
            _orderContext = orderContext;
        }

        public ActionResult AddToOrder(int Id,string controller,string action,string value)
        {
            return IncreaseCount(Id);
        }
        public ViewResult Index()
        {
            return View(GetOrder());
        }

        public RedirectToActionResult RemoveItem(int Id)
        {
            var order = GetOrder();

            order.Items.Remove(order.Items.Find(x => x.Product.Id == Id));
            SetOrder(order);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult IncreaseCount(int Id)
        {
            var order = GetOrder();
            var product = _productContext.Products.FirstOrDefault(x => x.Id == Id);
            if (product != null)
            {
                var orderProduct = order.Items.Find(x => x.Product.Id == Id);
                if (order.Items.Find(x => x.Product.Id == Id) != null)
                {
                    orderProduct.Count += 1;
                }
                else
                {
                    order.Items.Add(new OrderItem
                    {
                        Product = product,
                        Count = 1,
                    });
                }

            }
            SetOrder(order);
            return RedirectToAction("Index");


        }
        public RedirectToActionResult DecreaseCount(int Id)
        {
            var order = GetOrder();
            var product = _productContext.Products.FirstOrDefault(x => x.Id == Id);
            if (product != null)
            {
                var orderProduct = order.Items.Find(x => x.Product.Id == Id);
                if (order.Items.Find(x => x.Product.Id == Id) != null)
                {
                    if (orderProduct.Count > 1)
                        orderProduct.Count -= 1;
                    else
                        return RemoveItem(Id);
                }

            }
            SetOrder(order);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AddAdress(Order order)
        {
            ViewBag.DeliveryAreas = new SelectList(_deliveryAreaContext.DeliveryAreas.ToList(), "Id", "Name");
            return View("CompleteOrder", order);
        }
        [HttpPost]
        public IActionResult CompleteOrder(Order order)
        {
            if (SaveOrder(order))
            {
                ClearOrder();
                return RedirectToAction("EndOrder");
            }
            ViewBag.DeliveryAreas = new SelectList(_deliveryAreaContext.DeliveryAreas.ToList(), "Id", "Name");
            return View("CompleteOrder", order);
        }
        public IActionResult EndOrder()
        {
            return View();
        }

        private bool SaveOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }
            var addressId =SaveAddressAsync(order.Address).Result;
            var orderDb = new OrderDB();
            var orderDbItem = _orderContext.Orders.FirstOrDefault();
            if(orderDbItem == null)
            {
                orderDb.Id = 1;
            }
            else
            {
                var orderId = _orderContext.Orders.Max(x => x.Id);
                orderId++;
                orderDb.Id = orderId;
            }
            orderDb.Status = 0;
            orderDb.Description = order.Description;
            orderDb.AddressId = addressId;
            List<OrderDbItem> productDbList = new List<OrderDbItem>();
            order.Items.ForEach(x => productDbList.Add(OrderDbItem.ConvertProduct(x.Product,x.Count)));
            orderDb.Items= JsonConvert.SerializeObject(productDbList);
            _orderContext.Add(orderDb);
            _orderContext.SaveChanges();

            // SaveOrderInformation()
            return true;
        }

        private async Task<int> SaveAddressAsync(Address address)
        {
            
            var addressDbItem = _addressContext.Address.FirstOrDefault();
            if (addressDbItem == null)
            {
                address.Id = 1;
            }
            else
            {
                var addressId = _addressContext.Address.Max(x => x.Id);
                addressId++;
                address.Id = addressId;

            }
            if (string.IsNullOrEmpty(address.City))
                address.City = "Rostov-on-Don";
            _addressContext.Address.Add(address);
            await _addressContext.SaveChangesAsync();
            return address.Id;
        }

        public void ClearOrder()
        {
            HttpContext.Session.Clear();
        }
        public void SetOrder(Order order)
        {
            HttpContext.Session.Set<Order>("order", order);
        }
        public Order GetOrder()
        {
            if (HttpContext.Session.Keys.Contains("order"))
                return HttpContext.Session.Get<Order>("order");
            
            HttpContext.Session.Set<Order>("order", new Order());
            return HttpContext.Session.Get<Order>("order");
        }
    }
}
