//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using WaterDelivery.Models;

//namespace WaterDelivery.Controllers
//{
//    public class OrdersController : Controller
//    {
//        private DeliveryContext db = new DeliveryContext();

//        // GET: Orders
//        public ActionResult Index()
//        {
//            var orders = db.Orders.Include(o => o.User).Include(o => o.UserAddress);
            
//            return View(orders.ToList());
//        }

//        // GET: Orders/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Order order = db.Orders.Find(id);
//            User user = db.Users.Find(order.UserId);
//            UserAddress userAddress = db.UserAddresses.Find(user.Id);

//            ViewBag.Login = user.Login;
//            ViewBag.Address = userAddress.Address;
            
//            if (order == null)
//            {
//                return HttpNotFound();
//            }
//            return View(order);
//        }

//        // GET: Orders/Create
//        public ActionResult Create()
//        {
//            ViewBag.UserId = new SelectList(db.Users, "Id", "Login");
//            ViewBag.UserAddressId = new SelectList(db.UserAddresses, "Id", "Address");
//            return View();
//        }

//        // POST: Orders/Create
//        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
//        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,UserId,UserAddressId,WaterVolume,Date,Created_at,Updated_at")] Order order)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Orders.Add(order);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.UserId = new SelectList(db.Users, "Id", "Login", order.UserId);
//            ViewBag.UserAddressId = new SelectList(db.UserAddresses, "Id", "Address", order.UserAddressId);
//            return View(order);
//        }

//        // GET: Orders/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Order order = db.Orders.Find(id);
//            if (order == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.UserId = new SelectList(db.Users, "Id", "Login", order.UserId);
//            ViewBag.UserAddressId = new SelectList(db.UserAddresses, "Id", "Address", order.UserAddressId);
//            return View(order);
//        }

//        // POST: Orders/Edit/5
//        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
//        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,UserId,UserAddressId,WaterVolume,Date,Created_at,Updated_at")] Order order)
//        {
//            if (ModelState.IsValid)
//            {
//                order.Updated_at = DateTime.Now;
//                db.Entry(order).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.UserId = new SelectList(db.Users, "Id", "Login", order.UserId);
//            ViewBag.UserAddressId = new SelectList(db.UserAddresses, "Id", "Address", order.UserAddressId);
//            return View(order);
//        }

//        // GET: Orders/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Order order = db.Orders.Find(id);
//            User user = db.Users.Find(order.UserId);
//            UserAddress userAddress = db.UserAddresses.Find(user.Id);

//            ViewBag.Login = user.Login;
//            ViewBag.Address = userAddress.Address;
//            if (order == null)
//            {
//                return HttpNotFound();
//            }
//            return View(order);
//        }

//        // POST: Orders/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            Order order = db.Orders.Find(id);
//            db.Orders.Remove(order);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
