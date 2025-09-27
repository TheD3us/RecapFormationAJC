using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetDaoGenerique
{
    interface IDao<T, PK>
    {
        List<T> FindAll();
        T FindById(PK id);
        void Create(T obj);
        void Update(T obj);
        void Delete(PK id);
    }
}
