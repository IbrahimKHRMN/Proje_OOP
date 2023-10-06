﻿using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            context.Remove(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id) 
        {
            var value = context.Customers.Where(x=>x.CustomerId == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            var value = context.Customers.Where(x=> x.CustomerId==p.CustomerId).FirstOrDefault();
            value.CustomerCity = p.CustomerCity;
            value.CustomerName = p.CustomerName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
