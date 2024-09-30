using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    public class CustomersController : Controller
    {
        private readonly SellManagementDBContext db;

        public CustomersController(SellManagementDBContext db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            ViewBag.orders = db.Orders.ToList();
            return PartialView(db.Customers.OrderByDescending(x => x.CustomerId).ToList());
        }
        public ActionResult Create()
        {
            return PartialView(new Customer());
        }
        [HttpPost]
        public ActionResult Create(Customer c)
        {
            if (ModelState.IsValid && (c.CustomerName != null && c.CustomerAddress != null))
            {
                db.Customers.Add(c);
                db.SaveChanges();
                return Ok("success");
            }
            return Ok("failed");
        }
        public ActionResult Edit(int id)
        {
            return PartialView(db.Customers.First(x => x.CustomerId == id));
        }
        [HttpPost]
        public ActionResult Edit(Customer c)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
                return Ok("success");
            }
            return Ok("failed");
        }
        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                Customer c = new Customer() { CustomerId = (int)id };
                db.Entry(c).State = EntityState.Deleted;
                db.SaveChanges();
                return Ok("success");
            }
            return Ok("failed");
        }
    }
}
