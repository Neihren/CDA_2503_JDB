using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ClassLibIteratorPattern
{
    public class ListeDeJoueurs : IEnumerable
    {
        private List<Joueur> mesJoueurs;

        public ListeDeJoueurs()
        {
            mesJoueurs = new List<Joueur>();
        }

        public void AjouterJoueur(string _nom, string _prenom)
        {
            Joueur j = new Joueur(_nom, _prenom);
            mesJoueurs.Add(j);
        }

        public void SupprimerJoueur(string _nom, string _prenom)
        {
            int positionPersonne = -1;

            for (int i = 0; i < mesJoueurs.Count; i++)
            {
                if ((mesJoueurs[i].Nom.CompareTo(_nom) == 0) && (mesJoueurs[i].Prenom.CompareTo(_prenom) == 0))
                {
                    positionPersonne = i;
                }
            }

            if (positionPersonne != -1)
            {
                mesJoueurs.Remove(mesJoueurs[positionPersonne]);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new ConcreteListeDeJoueursEnumerator(this);
        }

        public int Count
        {
            get { return mesJoueurs.Count; }
        }

        public Joueur this[int index]
        {
            get { return mesJoueurs[index]; }
            set { mesJoueurs.Insert(index, value); }
        }

        public Joueur GetJoueurALaPosition(int position)
        {
            return mesJoueurs[position];
        }
    }

}
