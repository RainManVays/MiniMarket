using System;

namespace MiniMarket.Models
{
    public class OrderDB
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string Items { get; set; }
        public string ManagerComment { get; set; }
        public int AddressId { get; set; }
        public string Description { get; set; }
    }
}
