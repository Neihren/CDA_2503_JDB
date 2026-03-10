using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibIteratorPatternGenerique
{
    public class ListeDeJoueurs:IEnumerable<Joueur> //il réalise le contrat IEnumerable pour uniquement le Type Joueur
    {                                               
        private List<Joueur> mesJoueurs;



        public ListeDeJoueurs()
        {
            mesJoueurs = new List<Joueur>();
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

        public IEnumerator<Joueur> GetEnumerator()
        {
            return new ConcreteListeDeJoueursEnumerator(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
