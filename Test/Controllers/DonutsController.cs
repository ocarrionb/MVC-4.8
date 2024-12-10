using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Test.Models.BD;

namespace Test.Controllers
{
    public class DonutsController : Controller
    {
        /// <summary>
        /// Index 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            List<Donuts> donuts = new List<Donuts>(); ;
            using (var db = new Models.BD.GralContext())
            {
                donuts = (from d in db.Donuts
                          select new Donuts
                          {
                              Id = d.Id,
                              Name = d.Name
                          }).ToList();
            }
            return View(donuts);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Customer()
        {
            var customer = new List<Customer>();
            using (var db = new Models.BD.GralContext())
            {
                customer = (from d in db.Customer
                          select new Customer
                          {
                              CustomerId = d.CustomerId,
                              Name = d.Name
                          }).ToList();
            }
            return View(customer);
        }
    }
}
