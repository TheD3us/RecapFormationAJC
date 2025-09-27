using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            

            routes.MapRoute(
                name: "Objet",
                url: "Router/Objet/{refer}/{marque}/{prix}",
                defaults: new { controller = "Router", action = "Objet" }
            );

            routes.MapRoute(
                name: "Individu",
                url: "Router/Individu/{nom}/{prenom}/{age}",
                defaults: new { controller = "Router", action = "Individu", nom = UrlParameter.Optional, prenom = UrlParameter.Optional, age = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
