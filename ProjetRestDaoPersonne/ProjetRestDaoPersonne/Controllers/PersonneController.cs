using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TestMVC.Models;

namespace ProjetRestDaoPersonne.Controllers
{
    public class PersonneController : ApiController
    {
        [EnableCors(origins:"*", headers:"*", methods:"*")]
        // GET api/values
        [HttpGet]
        [Route("api/personne/list")]
        public List<Personne> Get()
        {
            return new DaoPersonne().SelectAll();
        }

        [HttpGet]
        [Route("api/personne/details/{id:int}")]
        // GET api/values/5
        public Personne Get(int id)
        {
            return new DaoPersonne().SelectById(id);
        }

        public void Post([FromBody]Personne p)
        {
            new DaoPersonne().Insert(p);
        }

        public void Put()
        {

        }
    }
}
