using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDll
{
    class DAOItem
    {
        public List<Item> SelectAll()
        {
            return new Db().SelectAll();
        }

        public void Insert(String Marque, double Prix)
        {
            new Db().Insert(Marque, Prix);
        }
    }
}
