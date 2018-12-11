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
    public class CategoriesController : Controller
    {

        CategoryContext _context;

        public CategoriesController(CategoryContext context)
        {
            _context = context;
        }




        public IActionResult Index()
        {
            return View(_context.Categories.ToList()); 
        }

        public ActionResult Create()
        {
            var category = _context.Categories.FirstOrDefault();
            if (category == null)
            {
                return View(new Category { Id = 1 });
            }
            else
            {
                var maxId = _context.Categories.Max(x => x.Id);
                maxId++;
                return View(new Category { Id = maxId });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View(category);
            }
        }
        public ActionResult Edit(int id)
        {
            return View(_context.Categories.FirstOrDefault(x=>x.Id==id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Category category)
        {
            try
            {
                var item = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
                item = category;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
               return View(category);
            }
        }
        public ActionResult Delete(int id)
        {
            _context.Categories.Remove(_context.Categories.FirstOrDefault(x => x.Id == id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}