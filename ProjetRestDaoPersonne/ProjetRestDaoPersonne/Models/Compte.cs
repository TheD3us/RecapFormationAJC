using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetRestDaoPersonne.Models
{
    public class Compte
    {
        int rib;
        string banque;
        double solde;

        public Compte()
        {

        }

        public Compte(int Rib, string Banque, double Solde)
        {
            this.rib = Rib;
            this.banque = Banque;
            this.solde = Solde;
        }

        public int Rib
        { get; set; }

        public string Banque
        { get; set; }

        public double Solde
        { get; set; }
    }
}