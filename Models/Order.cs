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
        public string UserDescription { get; set; }
        public string ManagerComment { get; set; }
    }
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}