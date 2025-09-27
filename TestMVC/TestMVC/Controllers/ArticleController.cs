using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectAll()
        {
            return View(new DAOArticle().selectAll());
        }

        public ActionResult Insert(int id, string Marque, double Prix)
        {
            
            new DAOArticle().Insert(id, Marque, Prix);
            return View();
        }

        public ActionResult SelectByRef(string Marque)
        {
            
            return View(new DAOArticle().SelectByRef(Marque));
        }
    }
}