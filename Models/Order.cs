using MiniMarket.Context;
using System;
using System.Collections.Generic;

namespace MiniMarket.Models
{
    public class Order
    {
        private List<OrderItem> _Items = new List<OrderItem>();

        public int Id { get; set; }
        public DateTime DateInsert { get; set; }
        public int Status { get; set; }
        public List<OrderItem> Items { get => this._Items; set => this._Items = value; }
        public string ManagerComment { get; set; }
        public Address Address { get;set;}
        public string Description { get; set; }
        public Order()
        {

        }
        public Order(OrderDB orderDB)
        {

        }

        private void ConvertOrderDbToOrder(OrderDB orderDB)
        {
            this.Id = orderDB.Id;
            //this.DateInsert
            this.Status = orderDB.Status;
            this.ManagerComment = orderDB.ManagerComment;
            this.Description = orderDB.Description;
            this.Items = ConvertJsonItemsToOrderItems(orderDB.Items);
            this.Address = new Address(new AddressContext(null), orderDB.AddressId);
        }

        private List<OrderItem> ConvertJsonItemsToOrderItems(string items)
        {
            throw new NotImplementedException();
        }
    }
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Count { get; set; }
    }
    public class OrderDbItem
    {
        public int ProductId { get; set; }
        public int Count { get; set; }


        public static OrderDbItem ConvertProduct(Product product,int Count)
        {
            return new OrderDbItem { ProductId = product.Id, Count = Count };
        }
    }
}