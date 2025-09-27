using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tpRestEfDaoArticle.Models
{
    public class ArticleDao
    {
        public List<articles> selectAll()
        {
            ajc_tpEntities context = new ajc_tpEntities();
            return context.articles.ToList();
        }

        public articles selectById(int id)
        {
            ajc_tpEntities context = new ajc_tpEntities();
            return context.articles.Where(a => a.@ref == id).First();
        }

        public void post(articles a)
        {
            ajc_tpEntities context = new ajc_tpEntities();
            context.articles.Add(a);
            context.SaveChanges();
        }

        public void put(articles a)
        {
            ajc_tpEntities context = new ajc_tpEntities();
            context.Entry(a).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void delete(int id)
        {
            ajc_tpEntities context = new ajc_tpEntities();
            articles a = context.articles.Where(ar => ar.@ref == id).FirstOrDefault();
            context.articles.Remove(a);
            context.SaveChanges();
        }

        
    }
}