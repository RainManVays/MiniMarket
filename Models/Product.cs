using System.Collections.Generic;

namespace MiniMarket.Models
{
    public class Product
    {
        public int Id {get;set;}
        public int CategoryId {get;set;}
        public string Name {get;set;}
        public Discount Discount {get;set;}
        public double Price {get;set;}
        public List<ProductAttribute> Attributes {get;set;}
        public bool isVisible {get;set;}
    }
}

