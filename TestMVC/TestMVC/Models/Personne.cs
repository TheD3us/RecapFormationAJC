using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVC.Models
{
    public class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private int age;
        public Personne()
        {

        }

        public Personne(int Id, string Nom, string Prenom, int Age)
        {
            this.id = Id;
            this.nom = Nom;
            this.prenom = Prenom;
            this.age = Age;
        }

        public override string ToString()
        {
            return nom + " " + prenom + " " + age;
        }

        public int Id
        {
            get { return this.id; }
        }

        public string Nom
        {
            get { return this.nom; }
        }

        public string Prenom
        {
            get { return this.prenom; }
        }

        public int Age
        {
            get { return this.age; }
        }
    }
}
