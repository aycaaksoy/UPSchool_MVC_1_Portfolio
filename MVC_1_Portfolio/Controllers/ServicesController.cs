using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_1_Portfolio.Models.Entities;
using Newtonsoft.Json.Linq;

namespace MVC_1_Portfolio.Controllers
{
    public class ServicesController : Controller
    {
        /*
         * To list
         * Add
         * Remove
         * Where
         */

        UpSchoolPortfolioEntities db = new UpSchoolPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddService(Service p)
        {
            db.Services.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult DeleteService(int id)
        {
            var values = db.Services.Find(id);
            db.Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}