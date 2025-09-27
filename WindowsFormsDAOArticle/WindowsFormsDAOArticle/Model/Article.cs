using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDAOArticle.Model
{
    class Article
    {
        int id;
        string marque;
        int prix;

        public Article()
        { }

        public Article(int id, string marque, int prix)
        {
            this.id = id;
            this.marque = marque;
            this.prix = prix;
        }

        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Marque
        {
            set { this.marque = value; }
            get { return this.marque; }
        }

        public int Prix
        {
            set { this.prix = value; }
            get { return this.prix; }
        }
        

    }
}
