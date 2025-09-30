using ProjetRestDaoPersonne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjetRestDaoPersonne.Controllers
{
    [EnableCors(origins: "*", headers:"*", methods:"*")]
    public class CompteController : ApiController
    {
        List<Compte> liste = new List<Compte> { new Compte(45648118, "CE", 45.2), new Compte(44894654, "CM", 7884), new Compte(48944148, "CA", 6663) };
        
        [HttpGet]
        [Route("api/compte/list")]
        public List<Compte> Get()
        {

            return liste;
        }

        [HttpGet]
        [Route("api/compte/list/{id:int}")]
        public Compte Get(int id)
        {

            return liste[id];
        }

        [HttpGet]
        [Route("api/compte/search/{rib:int}")]
        public Compte GetByRib(int rib)
        {
            Compte compte = null;
            foreach(Compte c in liste)
            {
                if(c.Rib == rib)
                {
                    compte = c;
                }
            }
            return compte;
            
        }

        [HttpPost]
        [Route("api/compte/list/add")]
        public void Post([FromBody]Compte c)
        {
            liste.Add(c);
        }

        [HttpGet]
        [Route("api/compte/liste/count")]
        public int Count()
        {
            return liste.Count;
        }

        [HttpGet]
        [Route("api/compte/liste/range")]
        public List<Compte> Range([FromUri]int min, [FromUri]int max)
        {
            List<Compte> listeRange = new List<Compte>();
            foreach(Compte c in liste)
            {
                if(c.Solde >= min && c.Solde <= max)
                {
                    listeRange.Add(c);
                }
            }
            return listeRange;
        }

    }
}
