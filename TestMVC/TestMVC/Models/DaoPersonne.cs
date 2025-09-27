
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVC.Models
{
    public class DaoPersonne
    {
        public List<Personne> SelectAll()
        {
            return new DataPersonne().SelectAll();
        }

        public void Insert(Personne p)
        {

        }
    }
}
