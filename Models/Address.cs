﻿using MiniMarket.Context;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MiniMarket.Models
{
    public class Address
    {
        public int Id { get; set; }
       // [StringLength(50)]
        public string City { get; set; }
       // [Required]
       // [StringLength(200, ErrorMessage = "Слишком длинный адрес")]
        public string Street { get; set; }

       // [Required]
       // [StringLength(20,ErrorMessage ="Слишком длинный номер")]
        public string Phone { get; set; }
        public string Email { get; set; }
        public int DeliveryAreaId { get; set; }
        
        public Address()
        {

        }

        public Address(AddressContext addressContext,int AdressId)
        {
           var address= addressContext.Address.FirstOrDefault(x => x.Id == AdressId);
            if (address != null)
            {
                this.Id = address.Id;
                this.City = address.City;
                this.DeliveryAreaId = address.DeliveryAreaId;
                this.Email = address.Email;
                this.Phone = address.Phone;
                this.Street = address.Street;
            }
        }
    }
}