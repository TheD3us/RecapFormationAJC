using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
    public class Client
    {
        private string nom;
        private string prenom;
        public Client()
        {

        }
        public Client(string nom, string prenom)
        {

            this.nom = nom;
            this.prenom = prenom;
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public override string ToString()
        {
            return nom + "     " + prenom;
        }
    }
}