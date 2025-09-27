using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tpRestEfDaoArticle.Models;

namespace tpRestEfDaoArticle.Controllers
{
    public class ArticleController : ApiController
    {
        
        public List<articles> Get()
        {
            return new ArticleDao().selectAll();
        }

        public articles Get(int id)
        {
            return new ArticleDao().selectById(id);
        }

        public void Post([FromBody] articles a)
        {
            new ArticleDao().post(a);
        }

        public void Put([FromBody] articles a)
        {
            new ArticleDao().put(a);

        }

        public void Delete(int id)
        {
            new ArticleDao().delete(id);
        }
    }
}
