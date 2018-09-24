using Microsoft.AspNetCore.Mvc;
using MiniMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniMarket.Controllers
{
    public class ProductController:Controller
    {
        List<Product> _product = new List<Product>
        {
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100},
            new Product{ Id=0,Name="test",CategoryId=1, isVisible=true, Image= new byte[0], Price=100}
        };

        public ProductController()
        {

        }


        public ViewResult ProductList(int category=0)
        {
            return View(_product);
        }

    }
}
