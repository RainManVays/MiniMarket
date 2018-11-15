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


namespace MiniMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductsController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            using (var context = new ProductContext())
            {
                return View(context.Products.ToList());
            }

        }

        // GET: Data/Create
        public ActionResult Create()
        {
            using (var context = new ProductContext())
            {
               int id= context.Products.Max(x => x.Id);
                id++;
               return View(new Product { Id = id });
            }
            
        }

        // POST: Data/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                using(var context = new ProductContext())
                {
                    int id = context.Products.Max(x => x.Id);
                    id++;
                    product.Id = id;
                    context.Products.Add(product);
                    context.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Data/Edit/5
        public ActionResult Edit(int id)
        {
            using (var context = new ProductContext())
            {
                return View(context.Products.FirstOrDefault(x=>x.Id==id));
            }

        }

        // POST: Data/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product, IFormFile image)
        {
            try
            {
                using (var context = new ProductContext())
                {
                    var item = context.Products.FirstOrDefault(x => x.Id == product.Id);
                    //item.Name = product.Name;
                    if(image != null && image.Length > 0)
                    {
                        using(var memoryStream = new MemoryStream())
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
                using (var context = new ProductContext())
                {
                    return View(product);
                }

            }
        }
        public FileContentResult GetProductImage(int Id)
        {
            using (ProductContext context = new ProductContext())
            {
                var product = context.Products.FirstOrDefault(x => x.Id == Id);
                if (product != null)
                    return File(product.Image, product.MIMEType);
            }
            return null;
        }

        // GET: Data/Delete/5
        public ActionResult Delete(int id)
        {
            using (var context = new ProductContext())
            {
                context.Products.Remove(context.Products.FirstOrDefault(x => x.Id == id));
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