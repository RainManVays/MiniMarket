using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Context;
using MiniMarket.Models;
using System.Linq;
namespace MiniMarket.Components
{
    public class CategoryMenu:ViewComponent
    {

        List<Category> _cat;
        public CategoryMenu()
        {
            using(var context = new CategoriesContext())
            {
              _cat= context.Categories.Where(x => x.isVisible == true).ToList();
            }
        }

        public IViewComponentResult Invoke()
        {
            return View("Menu",_cat);
        }


    }
}
