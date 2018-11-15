using Microsoft.AspNetCore.Mvc;
using MiniMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MiniMarket.Extensions;
using MiniMarket.Context;

namespace MiniMarket.Controllers
{
    public class OrderController : Controller
    {

        public ActionResult AddToOrder(int Id,string returnUrl)
        {
            return IncreaseCount(Id);
        }
        public ViewResult Index()
        {
            return View(GetOrder());
        }
        public decimal Summary(Order order)
        {
            decimal summ = 0;
            if (order != null)
            {
                foreach(var item in order.Items)
                    summ += item.Count * item.Product.Price;
            }
            return summ;
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
            using(ProductContext context = new ProductContext())
            {
                var product = context.Products.FirstOrDefault(x => x.Id == Id);
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
            }
            SetOrder(order);
            return RedirectToAction("Index");


        }
        public RedirectToActionResult DecreaseCount(int Id)
        {
            var order = GetOrder();
            using (ProductContext context = new ProductContext())
            {
                var product = context.Products.FirstOrDefault(x => x.Id == Id);
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
            }
            SetOrder(order);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Complete(Order order)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Complete(Order order,string address)
        {
            return View();
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
