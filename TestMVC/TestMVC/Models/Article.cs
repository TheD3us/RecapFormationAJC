using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVC.Models
{
    public class Article
    {
        private int id;
        private string marque;
        private double prix;

        public Article()
        {
        }

        public Article(int Id, string Marque, double Prix)
        {
            this.id = Id;
            this.marque = Marque;
            this.prix = Prix;
        }

        public string Marque
        {
            get { return this.marque; }
            set { this.marque = value; }
        }
        
        public double Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public override string ToString()
        {
            return this.marque + " " + this.prix + " euros";
        }
    }
}
