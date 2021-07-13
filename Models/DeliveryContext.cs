using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WaterDelivery.Models;
using Microsoft.AspNet.Identity.EntityFramework;
namespace WaterDelivery.Models { 
public class DeliveryContext :  IdentityDbContext
    {  
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
}

}
