using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ClassLibIteratorPatternGenerique
{
    public class ConcreteListeDeJoueursEnumerator : IEnumerator<Joueur>
    {
        private ListeDeJoueurs leConcreteAggregate;
        private int positionCourante = 0;

        public ConcreteListeDeJoueursEnumerator(ListeDeJoueurs _leConcreteAggregate)
        {
            leConcreteAggregate = _leConcreteAggregate;
        }

        public Joueur Current
        {
            get
            {
                if (positionCourante == -1)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    return leConcreteAggregate[positionCourante];
                }
            }
        }

        public void Dispose()           /*La méthode "Dispose" de cette interface  libère explicitement les ressources non managées avant que l'instance d'Enumérateur 
                                         soit supprimée(un fichier,une fenêtre soit supprimé) en association avec le garbage collector*/
        //Le consommateur d'un objet peut appeler cette méthode lorsque l'objet n'est plus nécessaire.
        {
            GC.SuppressFinalize(this); //Le garbage collector libère automatiquement la mémoire allouée à un objet managé lorsque cet objet n'est plus utilisé.
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            bool ret = false;

            if (positionCourante < leConcreteAggregate.Count - 1)
            {
                positionCourante = positionCourante + 1;
                ret = true;
            }
            else
            {
                ret = false;
            }
            return ret;
        }

        public void Reset()
        {
            positionCourante = 0;
        }
    }
}
