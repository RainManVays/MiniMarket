using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniMarket.Context;
using MiniMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniMarket.Controllers
{
    public class ProductController:Controller
    {
        public ProductController()
        {
        }


        public ViewResult ProductList(int category=0)
        {
            using(var context = new ProductContext())
            {
                return View(context.Products.Where(x => x.CategoryId == category).ToList());
            }
            
        }

    }
}
