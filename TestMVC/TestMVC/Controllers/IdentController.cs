using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVC.Controllers
{
    public class IdentController : Controller
    {
        // GET: Ident
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Connect()
        {
            return View();
        }
    }
}