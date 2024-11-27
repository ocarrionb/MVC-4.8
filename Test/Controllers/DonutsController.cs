using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Test.Models.BD;

namespace Test.Controllers
{
    public class DonutsController : Controller
    {
        //
        // GET: /Donuts/

        public ActionResult Index()
        {
            List<Donuts> donuts = new List<Donuts>();
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

    }
}
