using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page1()
        {
            return View();
        }

        public ActionResult Page2(Client c)
        {
            return View(c);
        }

        public ActionResult Action1()
        {
            return View();
        }

        public ActionResult Action2(Article a)
        {
            return View(a);
        }

        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test(Client c)
        {
            return View(c);
        }
    }
}