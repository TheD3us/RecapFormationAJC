using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class ArticleFormController : Controller
    {
        // GET: ArticleForm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetDao()
        {
            DAOArticle a = new DAOArticle();
            return View(a);
        }

        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test(Article c)
        {
            return View(c);
        }

        public ActionResult Marque(Article a)
        {
            return View(a);
        }

        [HttpGet]
        public ActionResult GoInsert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoInsert(Article p)
        {
            DAOArticle d = new DAOArticle();
            d.Insert(p.Id, p.Marque, p.Prix);
            return View();
        }

        [HttpGet]
        public ActionResult GoInsertUpdate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoInsertUpdate(Article p)
        {
            DAOArticle d = new DAOArticle();
            d.Update(p);
            return View(p);
        }

        [HttpGet]
        public ActionResult GoDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            string vue;
            DAOArticle d = new DAOArticle();
            Article a = d.SelectById(id);

            if(a != null)
            {
                d.Delete(id);
                vue = "Delete";
            }
            else
            {
                vue = "Error";
                ViewBag.Message = id;
            }
            
            return View(vue, a);
        }




    }
}