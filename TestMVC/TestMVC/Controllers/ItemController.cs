using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            Item i = new Item(1, "Golio", 40);
            //string s = i.Reference + " " + i.Marque + " " + i.Prix;
            return View(i);
        }

        public ActionResult AfficheItem(int id, string marque, double prix)
        {
            Item i = new Item(id, marque, prix);
            return View(i);
            
        }

        public ActionResult ListeItem()
        {
            List<Item> list = new List<Item>();
            list.Add(new Item(4, "Frere", 88));
            list.Add(new Item(5, "Yuiii", 87));
            list.Add(new Item(6, "Dede", 22));
            return View(list);
        }
    }
}