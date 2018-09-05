namespace MiniMarket.Models
{
    public class Category
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public Discount Discount {get;set;}
        public bool isVisible {get;set;}
    }
}