using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ClassLibIteratorPattern
{
    public class Joueur
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        
        public Joueur(string _nom,string _prenom) 
        {
            nom = _nom;
            prenom = _prenom;
        }
    }
}
