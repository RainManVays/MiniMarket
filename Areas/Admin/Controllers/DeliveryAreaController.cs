using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Context;
using MiniMarket.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniMarket.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class DeliveryAreaController : Controller
    {

        DeliveryAreaContext _context;
        public DeliveryAreaController(DeliveryAreaContext context)
        {
            _context = context;
        }

        // GET: Data
        public ActionResult Index()
        {
                return View(_context.DeliveryAreas.ToList());
        }

        // GET: Data/Create
        public ActionResult Create()
        {
                var stock = _context.DeliveryAreas.FirstOrDefault();
                if (stock == null)
                {
                    return View(new DeliveryArea { Id = 1 });
                }
                else
                {
                    int id = _context.DeliveryAreas.Max(x => x.Id);
                    id++;
                    return View(new DeliveryArea { Id = id });
                }
        }

        // POST: Data/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DeliveryArea deliveryArea, IFormFile image)
        {
            try
            {
                    if (image != null && image.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            image.CopyTo(memoryStream);
                            deliveryArea.Image = memoryStream.ToArray();
                            deliveryArea.MIMEType = image.ContentType;
                        }
                    }
                    _context.DeliveryAreas.Add(new DeliveryArea
                    {
                        Id = deliveryArea.Id,
                        Name=deliveryArea.Name,
                        Image = deliveryArea.Image,
                        MIMEType = deliveryArea.MIMEType
                    });
                    _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Data/Edit/5
        public ActionResult Edit(int id)
        {
                return View(_context.DeliveryAreas.FirstOrDefault(x => x.Id == id));
        }

        // POST: Data/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DeliveryArea deliveryArea, IFormFile image)
        {
            try
            {
                    var item = _context.DeliveryAreas.FirstOrDefault(x => x.Id == deliveryArea.Id);
                    item.Name = deliveryArea.Name;
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
                return View(deliveryArea);
            }
        }
        public FileContentResult GetDeliveryAreaImage(int Id)
        {
            var stock = _context.DeliveryAreas.FirstOrDefault(x => x.Id == Id);
            if (stock != null)
                return File(stock.Image, stock.MIMEType);
            return null;
        }

        // GET: Data/Delete/5
        public ActionResult Delete(int id)
        {
            _context.DeliveryAreas.Remove(_context.DeliveryAreas.FirstOrDefault(x => x.Id == id));
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
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
