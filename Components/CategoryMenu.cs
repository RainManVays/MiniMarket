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

        public CategoryMenu(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IViewComponentResult Invoke()
        {
            if (!_cache.TryGetValue(0, out List<Category> category))
            {
                using (CategoryContext context = new CategoryContext())
                {
                    _cache.Set(0, context.Categories.ToList(), TimeSpan.FromHours(1));
                }
            }

            return View("Menu",_cache.Get(0));
        }


    }
}
