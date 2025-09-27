using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test1()
        {
            ViewBag.message = "test";
            Data d = new Data("Coucou");
            return View(d);
        }

        public ActionResult Test2()
        {
            return View();
        }

        public ActionResult GoGreeting()
        {
            Traitement t = new Traitement();
            return View(t);
        }

        public ActionResult Test4(string id, string nom, string prenom, string age)
        {
            string str = id + " " + nom + " " + prenom + " " + age;
            Data d = new Data(str);
            return View("Test1", d);
        }

        public ActionResult Test5()
        {
            return View(new Client("toto", "titi"));
        }

        public ActionResult Test8()
        {
            return View();
        }

        public ActionResult Test9()
        {
            return View();
        }

        public ActionResult Test12()
        {
            int c = (int)HttpContext.Application["site"];
            c += 1;
            HttpContext.Application["site"] = c;
            return View();
        }

        public ActionResult Test13()
        {
            Item i = new Item(4, "looo", 78);
            HttpContext.Application["site"] = i.Reference + " " + i.Marque + " " + i.Prix;
            return View();
        }

        public ActionResult Test14()
        {
            Item i = new Item(4, "looo", 78);
            HttpContext.Application["item"] = i;
            return View();
        }
    }
}