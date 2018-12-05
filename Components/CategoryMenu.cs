using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Context;
using MiniMarket.Models;
using System.Linq;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace MiniMarket.Components
{
    public class CategoryMenu:ViewComponent
    {
        IMemoryCache _cache;

        public CategoryMenu(IMemoryCache cache, CategoryContext context)
        {
            _cache = cache;
            _context = context;
        }

        public CategoryContext _context { get; }

        public IViewComponentResult Invoke()
        {
            if (!_cache.TryGetValue(0, out List<Category> category))
            {
                    _cache.Set(0, _context.Categories.ToList(), TimeSpan.FromHours(1));
            }

            return View("Menu",_cache.Get(0));
        }


    }
}
