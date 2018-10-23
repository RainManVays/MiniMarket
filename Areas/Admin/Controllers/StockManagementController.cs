using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Context;
using MiniMarket.Models;

namespace MiniMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StockManagementController : Controller
    {

        // GET: Data
        public ActionResult Index()
        {
            using (var context = new StockContext())
            {
                return View(context.Stocks.ToList());
            }

        }

        // GET: Data/Create
        public ActionResult Create()
        {
            using (var context = new StockContext())
            {
                var stock = context.Stocks.FirstOrDefault();
                if (stock == null)
                {
                    return View(new Stock { Id = 1 });
                }
                else
                {
                    int id = context.Stocks.Max(x => x.Id);
                    id++;
                    return View(new Stock { Id = id });
                }
                
            }

        }

        // POST: Data/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stock stock, IFormFile image)
        {
            try
            {
                using (var context = new StockContext())
                {
                    if (image != null && image.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            image.CopyTo(memoryStream);
                            stock.Image = memoryStream.ToArray();
                            stock.MIMEType = image.ContentType;
                        }
                    }
                    context.Stocks.Add(new Stock
                    {
                        Id = stock.Id,
                        Image=stock.Image,
                        MIMEType=stock.MIMEType
                    });
                    context.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: Data/Edit/5
        public ActionResult Edit(int id)
        {
            using (var context = new StockContext())
            {
                return View(context.Stocks.FirstOrDefault(x => x.Id == id));
            }

        }

        // POST: Data/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Stock stock, IFormFile image)
        {
            try
            {
                using (var context = new StockContext())
                {
                    var item = context.Stocks.FirstOrDefault(x => x.Id == stock.Id);
                    //item.Name = product.Name;
                    if (image != null && image.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            image.CopyTo(memoryStream);
                            item.Image = memoryStream.ToArray();
                            item.MIMEType = image.ContentType;
                        }
                    }
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                using (var context = new StockContext())
                {
                    return View(stock);
                }

            }
        }
        public FileContentResult GetStockImage(int Id)
        {
            using (StockContext context = new StockContext())
            {
                var stock = context.Stocks.FirstOrDefault(x => x.Id == Id);
                if (stock != null)
                    return File(stock.Image, stock.MIMEType);
            }
            return null;
        }

        // GET: Data/Delete/5
        public ActionResult Delete(int id)
        {
            using (var context = new StockContext())
            {
                context.Stocks.Remove(context.Stocks.FirstOrDefault(x => x.Id == id));
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        // POST: Data/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}