using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestMVC.Models;

namespace TpRestDaoArticle.Controllers
{
    public class ArticleController : ApiController
    {

        // GET api/values
        public List<Article> Get()
        {
            return new DAOArticle().SelectAll();
        }

        // GET api/values/5
        public Article Get(int id)
        {
            return new DAOArticle().SelectById(id);
        }

        public void Insert(int Id, string Marque, double Prix)
        {
            new DAOArticle().Insert(Id, Marque, Prix );
        }

        public void Put([FromBody]Article a)
        {
            new DAOArticle().Update(a);
        }

        public void Delete(int id)
        {
            new DAOArticle().Delete(id);
        }
    }
}
