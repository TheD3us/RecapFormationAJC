using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetDaoGenerique
{
    class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private int age;

        public int Id
        {
            get
            {
                return id;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }
        }

        public Personne(int id, string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.id = id;
        }
        public Personne() { }
        public override string ToString()
        {

            return id + "    " + nom + "    " + prenom + "    " + age;
        }
    }
}
