using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpSerialization
{
    [Serializable]
    class Article
    {
        string marque;
        double prix;

        public Article(string Marque, double Prix)
        {
            this.marque = Marque;
            this.prix = Prix;
        }

        public override string ToString()
        {
            return marque + " " + prix;
        }
    }
}
