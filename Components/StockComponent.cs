using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using MiniMarket.Context;
using MiniMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMarket.Components
{
    public class StockComponent : ViewComponent
    {
        IMemoryCache _cache;
        StockContext _context;
        public StockComponent(IMemoryCache cache,StockContext context)
        {
            _cache = cache;
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            if (!_cache.TryGetValue(0, out List<Stock> stock))
            {
               _cache.Set(0, _context.Stocks.ToList(), TimeSpan.FromHours(1));
            }

            return View("Stock", _cache.Get(0));
        }


    }
}