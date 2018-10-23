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
        public ProductController(IMemoryCache cache)
        {
            _cache = cache;
        }


        public ViewResult ProductList(int category=0)
        {
            
            if(!_cache.TryGetValue(category,out List<Product> product))
            {
                using (var context = new ProductContext())
                {
                    _cache.Set(category, context.Products.Where(x => x.CategoryId == category).ToList(),TimeSpan.FromMinutes(3));
                }
            }
            
             return View(_cache.Get(category));
        
        }

        public FileContentResult GetProductImage(int Id)
        {
            using(ProductContext context = new ProductContext())
            {
                var product = context.Products.FirstOrDefault(x => x.Id == Id);
                if (product != null)
                    return File(product.Image,product.MIMEType);
            }
            return null;
        }


    }

}

