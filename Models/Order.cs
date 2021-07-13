using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterDelivery.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int UserAddressId { get; set; }
        public UserAddress UserAddress { get; set; }
        public int WaterVolume { get; set; }
        public DateTime Date { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        

    }
}