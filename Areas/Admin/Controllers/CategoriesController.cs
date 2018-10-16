using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Context;
using MiniMarket.Models;

namespace MiniMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            using(var context = new MiniMarketContext())
            {
                return View(context.Categories.ToList()); 
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                using (var context = new MiniMarketContext())
                {
                    context.Categories.Add(category);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                return View(category);
            }
        }
        public ActionResult Edit(int id)
        {
            using (var context = new MiniMarketContext())
            {
                return View(context.Categories.FirstOrDefault(x=>x.Id==id));
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Category category)
        {
            try
            {
                using (var context = new MiniMarketContext())
                {
                    var item = context.Categories.FirstOrDefault(x => x.Id == category.Id);
                    item = category;
                    await context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                using (var context = new ProductContext())
                {
                    return View(category);
                }

            }
        }
        public ActionResult Delete(int id)
        {
            using(var context = new MiniMarketContext())
            {
                context.Categories.Remove(context.Categories.FirstOrDefault(x => x.Id == id));
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}