using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Models;

namespace MiniMarket.Components
{
    public class CategoryMenu:ViewComponent
    {

        List<Category> _cat = new List<Category>{
           new Category{Id=1,Name="Классические",isVisible=true, Image=new byte[0] },
           new Category{Id=2,Name="Сеты",isVisible=true, Image=new byte[0]},
           new Category{Id=1,Name="Запеченные",isVisible=true, Image=new byte[0] },
           new Category{Id=2,Name="Суши",isVisible=true, Image=new byte[0]},
           new Category{Id=1,Name="Сложные роллы",isVisible=true, Image=new byte[0] },
           new Category{Id=2,Name="Закуски",isVisible=true, Image=new byte[0]},
            new Category{Id=2,Name="Пицца",isVisible=true, Image=new byte[0]}
       };

        public CategoryMenu()
        {

        }

        public IViewComponentResult Invoke()
        {
            return View("Menu",_cat);
        }


    }
}
