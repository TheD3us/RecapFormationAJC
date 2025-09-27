
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestMVC.Models
{
    public class DAOArticle
    {
        public List<Article> selectAll()
        {
            return new Db().SelectAll();
        }

        public Article SelectByRef(string Ref)
        {
            return new Db().SelectByRef(Ref);
        }

        public void Insert(int Id, string Marque, double Prix)
        {
            new Db().Insert(Id, Marque, Prix);
        }

        public void Update(Article a)
        {
            new Db().Update(a);
        }

        public void Delete(int i)
        {
            new Db().Delete(i);
        }

        public Article SelectById(int i)
        {
            return new Db().SelectById(i);
        }
    }
}
