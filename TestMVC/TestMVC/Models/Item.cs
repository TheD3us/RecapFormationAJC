using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
    public class Item
    {
        int reference;
        string marque;
        double prix;

        public Item(int Reference, string Marque, double Prix)
        {
            this.reference = Reference;
            this.marque = Marque;
            this.prix = Prix;
        }

        public int Reference
        {
            get { return this.reference; }
        }

        public string Marque
        {
            get { return this.marque; }
        }

        public double Prix
        {
            get { return this.prix; }
        }

    }
}