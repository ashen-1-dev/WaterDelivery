using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WaterDelivery.Models
{
    public class DeliveryDbInitializer : DropCreateDatabaseAlways<DeliveryContext>
    {
        protected override void Seed(DeliveryContext db)
        {
            //db.Users.Add(new User
            //{
            //    Id = 1,
            //    Logins = "ivanov123",
            //    Password = "1234",
            //    Name = "Иван",
            //    Surname = "Иванов",
            //    Email = "example1@mail.ru",
            //    Number = "8952185940",
            //    Created_at = new DateTime(2021, 7, 9),
            //    Updated_at = new DateTime(2021, 7, 9)
            //});

            //db.Users.Add(new User
            //{
            //    Id = 2,
            //    Login = "petrov123",
            //    Password = "1234",
            //    Name = "Петр",
            //    Surname = "Петров",
            //    Email = "example2@mail.ru",
            //    Number = "89521815941",
            //    Created_at = new DateTime(2021, 7, 10),
            //    Updated_at = new DateTime(2021, 7, 10)
            //});

            //db.Users.Add(new User
            //{
            //    Id = 3,
            //    Login = "egor123",
            //    Password = "1234",
            //    Name = "Егор",
            //    Surname = "Егоров",
            //    Email = "example3@mail.ru",
            //    Number = "89521815942",
            //    Created_at = new DateTime(2021, 7, 11),
            //    Updated_at = new DateTime(2021, 7, 11)
            //});

            //db.UserAddresses.Add(new UserAddress
            //{
            //    Id = 1,
            //    UserId = 1,
            //    Address = "ул. Пушкина, д.103, кв. 10"
            //});

            //db.UserAddresses.Add(new UserAddress
            //{
            //    Id = 2,
            //    UserId = 2,
            //    Address = "ул. Ленина, д.54, кв. 2"
            //});

            //db.UserAddresses.Add(new UserAddress
            //{
            //    Id = 3,
            //    UserId = 3,
            //    Address = "ул. Говорова, д.33, кв. 40"
            //});

            //db.Orders.Add(new Order
            //{
            //    Id = 1,
            //    UserId = 1,
            //    UserAddressId = 1,
            //    WaterVolume = 5,
            //    Date = new DateTime(2021, 10, 11),
            //    Created_at = new DateTime(2021, 7, 10),
            //    Updated_at = new DateTime(2021, 7, 11)
            //});

            //db.Orders.Add(new Order
            //{
            //    Id = 2,
            //    UserId = 2,
            //    UserAddressId = 2,
            //    WaterVolume = 5,
            //    Date = new DateTime(2021, 10, 11),
            //    Created_at = new DateTime(2021, 7, 10),
            //    Updated_at = new DateTime(2021, 7, 11)
            //});

            //base.Seed(db);
        }
    }
}