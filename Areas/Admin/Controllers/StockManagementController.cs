using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Context;
using MiniMarket.Models;

namespace MiniMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class StockManagementController : Controller
    {
        StockContext _context;

        public StockManagementController(StockContext context)
        {
            _context = context;
        }
        // GET: Data
        public ActionResult Index()
        {
           return View(_context.Stocks.ToList());
        }

        // GET: Data/Create
        public ActionResult Create()
        {
                var stock = _context.Stocks.FirstOrDefault();
                if (stock == null)
                {
                    return View(new Stock { Id = 1 });
                }
                else
                {
                    int id = _context.Stocks.Max(x => x.Id);
                    id++;
                    return View(new Stock { Id = id });
                }

        }

        // POST: Data/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Stock stock, IFormFile image)
        {
            try
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
                    _context.Stocks.Add(new Stock
                    {
                        Id = stock.Id,
                        Image=stock.Image,
                        MIMEType=stock.MIMEType
                    });
                    _context.SaveChanges();
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
          return View(_context.Stocks.FirstOrDefault(x => x.Id == id));
        }

        // POST: Data/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Stock stock, IFormFile image)
        {
            try
            {
                    var item = _context.Stocks.FirstOrDefault(x => x.Id == stock.Id);
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
                    _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                    return View(stock);
            }
        }
        public FileContentResult GetStockImage(int Id)
        {
            var stock = _context.Stocks.FirstOrDefault(x => x.Id == Id);
            if (stock != null)
                return File(stock.Image, stock.MIMEType);
            return null;
        }

        // GET: Data/Delete/5
        public ActionResult Delete(int id)
        {
            _context.Stocks.Remove(_context.Stocks.FirstOrDefault(x => x.Id == id));
            _context.SaveChanges();
            return RedirectToAction("Index");
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