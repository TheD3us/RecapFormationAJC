using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsDAOArticle.Model;

namespace WindowsFormsDAOArticle.DAO
{
    class DAOArticle
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
    }
}
