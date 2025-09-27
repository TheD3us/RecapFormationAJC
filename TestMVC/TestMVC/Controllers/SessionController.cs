using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page1()
        {
            
            List<Item> list = new List<Item>();
            list.Add(new Item(4, "Frere", 88));
            list.Add(new Item(5, "Yuiii", 87));
            list.Add(new Item(6, "Dede", 22));
            if(Session["list"] == null )
            {
                Session["list"] = list;
            }
            

            return View();
        }

        public ActionResult Page2()
        {
            
            return View();
        }

        public ActionResult Page3()
        {

            return View();
        }

        public ActionResult Count()
        {
            int count = 1;
            if (Session["nb"] == null) { Session["nb"] = 1; count = 1; }
            else { count = Convert.ToInt32(Session["nb"]);  count += 1; Session["nb"] = Convert.ToString(count); }
            return View();
        }
    }
}