using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WaterDelivery.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        public ICollection<UserAddress> Addresses { get; set; }
        public ICollection<Order> Orders { get; set; }
        
        public User()
        {
            Addresses = new List<UserAddress>();
            Orders = new List<Order>();
        }

    }
}