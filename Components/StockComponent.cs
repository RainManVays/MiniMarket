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

        public StockComponent(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IViewComponentResult Invoke()
        {
            if (!_cache.TryGetValue(0, out List<Stock> stock))
            {
                using (StockContext context = new StockContext())
                {
                    _cache.Set(0, context.Stocks.ToList(), TimeSpan.FromHours(1));
                }
            }

            return View("Stock", _cache.Get(0));
        }


    }
}