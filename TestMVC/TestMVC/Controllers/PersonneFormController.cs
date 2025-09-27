using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class PersonneFormController : Controller
    {
        // GET: PersonneForm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPlus()
        {
            DaoPersonne d = new DaoPersonne();
            return View(d);
        }

        [HttpGet]
        public ActionResult GoInsert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoInsert(Personne p)
        {
            DaoPersonne d = new DaoPersonne();
            d.Insert(p);
            return View();
        }
    }
}