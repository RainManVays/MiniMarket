using MiniMarket.Context;
using System.Linq;

namespace MiniMarket.Models
{
    public class Product
    {
        public int Id {get;set;}
        public int CategoryId {get;set;}
        public string Name {get;set;}
        public Discount Discount {get;set;}
        public decimal Price {get;set;}
        public int Weight { get; set; }
        public byte[] Image { get; set; }
       // public List<ProductAttribute> Attributes {get;set;}
        public string MIMEType { get; set; }
        public bool isVisible {get;set;}
        public string Description { get; set; }
        
        public Product()
        {

        }
        public Product(ProductContext productContext,int ProductId)
        {
            ConvertProductIdToProduct(productContext, ProductId);
        }
        public void ConvertProductIdToProduct(ProductContext productContext, int ProductId)
        {
            var product = productContext.Products.FirstOrDefault(x => x.Id == ProductId);
            if (product != null)
            {
                this.Id = product.Id;
                this.CategoryId = product.CategoryId;
                this.Name = product.Name;
                this.Discount = product.Discount;
                this.Price = product.Price;
                this.Weight = product.Weight;
                this.Image = product.Image;
                this.MIMEType = product.MIMEType;
                this.isVisible = product.isVisible;
                this.Description = product.Description;
            }
        }
    }
}

