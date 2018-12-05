using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using MiniMarket.Context;
using MiniMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MiniMarket.Controllers
{
    public class ProductController:Controller
    {
        private IMemoryCache _cache;
        private ProductContext _context;

        public ProductController(IMemoryCache cache, ProductContext context)
        {
            _cache = cache;
            _context = context;
        }


        public ViewResult ProductList(int category=0)
        {
            
            if(!_cache.TryGetValue(category,out List<Product> product))
            {
               _cache.Set(category, _context.Products.Where(x => x.CategoryId == category).ToList(),TimeSpan.FromMinutes(3));
            }
            
             return View(_cache.Get(category));
        
        }

        public FileContentResult GetProductImage(int Id)
        {
                var product = _context.Products.FirstOrDefault(x => x.Id == Id);
                if (product != null)
                    return File(product.Image,product.MIMEType);
            return null;
        }


    }

}

