using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDll
{
    public class Item
    {
        int id;
        string marque;
        double prix;

        public Item()
        {

        }
        public Item(string marque, double prix)
        {
            this.marque = marque;
            this.prix = prix;
        }

        public String Marque
        {
            set { this.marque = value; }
            get { return this.marque; }
        }

        public double Prix
        {
            set { this.prix = value; }
            get { return prix; }
        }

        public int Id
        {
            get { return id; }
        }

    }
}
