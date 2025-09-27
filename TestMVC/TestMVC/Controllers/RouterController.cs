using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVC.Controllers
{
    public class RouterController : Controller
    {
        // GET: Router
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Objet(int refer, string marque, double prix)
        {
            ViewBag.Message = $"{refer} {marque} {prix}";
            return View();
        }

        public ActionResult Individu(string nom, string prenom, int age)
        {
            ViewBag.Message = $"{nom}  {prenom}  {age}";
            return View();
        }
    }
}