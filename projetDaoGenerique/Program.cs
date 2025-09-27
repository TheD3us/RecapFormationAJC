using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetDaoGenerique
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSelect();
        }

        static void TestSelect()
        {
          
            IDaoPersonne x = new DaoPersonneSqlServer();
            GeneriqueSelect(x);

            IDaoPersonne y = new DaoPersonneOracle();
           // GeneriqueSelect(y);

        }
        static void GeneriqueSelect(IDaoPersonne d)
        {
            foreach (Personne p in d.FindAll())
                Console.WriteLine(p);
                } 
        static void TestCreate()
        {
            Personne p = new Personne(154, "aaa", "bbb", 10);
            DaoPersonneSqlServer x = new DaoPersonneSqlServer();
            x.Create(p);


        }

      
    }
}
