using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Compte
    {
        private int numero;
        private string nom;
        private double solde;
        private double decouvertAutorise;



        public Compte()
        {
            this.numero = 0;
            this.nom = "";
            this.solde = 0;
            this.decouvertAutorise = 0;
        }

        public Compte(int Numero, string Nom, double Solde, double DecouvertAutorise)
        {
            this.numero = Numero;
            this.nom = Nom;
            this.solde = Solde;
            this.decouvertAutorise = DecouvertAutorise;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }
        public double DecouvertAutorise
        {
            get { return decouvertAutorise; }
            set { decouvertAutorise = value; }
        }

        public void crediter(double montant)
        {
            this.solde = this.solde + montant;
        }

        public bool debiter(double montant)
        {
            bool ok = false;

            if (this.solde - montant >= this.decouvertAutorise)
            {
                this.solde = this.solde - montant;
                ok = true;
            }

            return ok;

        }

        public bool transferer(double montant, Compte solde2)
        {
            bool ok = false;

            if (this.debiter(montant))
            {
                solde2.crediter(montant);
                ok = true;
            }


            return ok;
        }

        public bool superieur(Compte solde2)
        {
            bool ok = false;

            if (this.solde > solde2.solde)
            {
                ok = true;
            }

            return ok;
        }

        public override string ToString()
        {
            return "le numéro de compte est : " + this.numero + "\n"
                 + "\n le nom est : " + this.nom + "\n"
                 + "\n le solde est de : " + this.solde + "\n"
                 + "\n Le découvert est à " + this.decouvertAutorise
                 ;

        }
    }
}

