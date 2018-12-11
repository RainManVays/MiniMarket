using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MiniMarket.Context;
using Newtonsoft.Json;
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
        
        public Order(OrderDB orderDB, AddressContext addressContext, ProductContext productContext)
        {
            ConvertOrderDbToOrder(orderDB, addressContext, productContext);
        }

        private void ConvertOrderDbToOrder(OrderDB orderDB, AddressContext addressContext, ProductContext productContext)
        {
            this.Id = orderDB.Id;
            //this.DateInsert
            this.Status = orderDB.Status;
            this.ManagerComment = orderDB.ManagerComment;
            this.Description = orderDB.Description;

            var orderDbItems=  ConvertJsonItemsToOrderItems(orderDB.Items);
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach(var orderDbItem in orderDbItems)
            {
                var product = new Product(productContext, orderDbItem.ProductId);
                orderItems.Add(new OrderItem
                {
                    Product = product,
                    Count = orderDbItem.Count
                });
            };
            this.Items = orderItems;

            this.Address = new Address(addressContext, orderDB.AddressId);
        }

        private List<OrderDbItem> ConvertJsonItemsToOrderItems(string items)
        {
            return JsonConvert.DeserializeObject<List<OrderDbItem>>(items);
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