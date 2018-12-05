using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MiniMarket.Context;
using MiniMarket.Models;


namespace MiniMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductsController : Controller
    {

        ProductContext _productContext;
        CategoryContext _categoryContext;
        public ProductsController(ProductContext context, CategoryContext categoryContext)
        {
            _productContext = context;
            _categoryContext = categoryContext;
        }
        // GET: Data
        public ActionResult Index()
        {
                return View(_productContext.Products.ToList());
        }

        // GET: Data/Create
        public ActionResult Create()
        {
            var category = _productContext.Products.FirstOrDefault();
            if (category == null)
            {
                return View(new Product { Id = 1 });
            }
            else
            {
                var maxId = _productContext.Products.Max(x => x.Id);
                maxId++;
                return View(new Product { Id = maxId });
            }
        }

        // POST: Data/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
           
               // int id = _productContext.Products.Max(x => x.Id);
               // id++;
               // product.Id = id;
                _productContext.Products.Add(product);
                _productContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Data/Edit/5
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var categories = _categoryContext.Categories.ToList();
            var selectListCategories = new SelectList(categories, "Id", "Name", _productContext.Products.FirstOrDefault(x => x.Id == Id).CategoryId);
            ViewBag.Categories = selectListCategories;

           return View(_productContext.Products.FirstOrDefault(x=>x.Id==Id));
        }

        // POST: Data/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product, IFormFile image)
        {
            try
            {
                var item = _productContext.Products.FirstOrDefault(x => x.Id == product.Id);
                item.Name = product.Name;
                item.CategoryId = product.CategoryId;
                item.Description = product.Description;
                item.isVisible = product.isVisible;
                item.Price = product.Price;
                item.Discount = product.Discount;
                if(image != null && image.Length > 0)
                {
                    using(var memoryStream = new MemoryStream())
                    {
                        image.CopyTo(memoryStream);
                        item.Image = memoryStream.ToArray();
                        item.MIMEType = image.ContentType;
                    }
                }
                _productContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
              return View(product);
            }
        }
        public FileContentResult GetProductImage(int Id)
        {
                var product = _productContext.Products.FirstOrDefault(x => x.Id == Id);
                if (product != null)
                    return File(product.Image, product.MIMEType);
            return null;
        }

        // GET: Data/Delete/5
        public ActionResult Delete(int id)
        {
            _productContext.Products.Remove(_productContext.Products.FirstOrDefault(x => x.Id == id));
            _productContext.SaveChanges();
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