using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Models;

namespace MiniMarket.Controllers
{
    public class HomeController : Controller
    {
        List<Category> _cat= new List<Category>{
           new Category{Id=1,Name="Swimsuit"},
           new Category{Id=2,Name="Hats"},
           new Category{Id=3,Name="Tops"},
       };
        public IActionResult Index()
        {
            return View(_cat);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
