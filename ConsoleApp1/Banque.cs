using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Banque
    {
        public Banque()
        {
            mesComptes = new List<Compte>();
        }
        private List<Compte> mesComptes;

       public List<Compte> MesComptes
        {
            get { return mesComptes; }
            set { mesComptes = value; }
        }
        public void AjouterCompte(Compte c)
        {
            mesComptes.Add(c);
        }
        public void AjouterCompte(int Numero, string Nom, double Solde, double DecouvertAutorise)
        {
            Compte c = new Compte(Numero, Nom, Solde, DecouvertAutorise);
            mesComptes.Add(c);
        }
    }
}
  
