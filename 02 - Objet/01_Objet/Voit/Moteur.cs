using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voit
{
    public class Moteur
    {
        private int puissanceEnChevaux;
        private bool estEntrainDeTourner;

        public Moteur(int puissanceEnChevaux, bool estEntrainDeTourner)
        {
            this.puissanceEnChevaux = puissanceEnChevaux;
            this.estEntrainDeTourner = estEntrainDeTourner;
        }

        public Moteur() : this(0, false)
        {
        }

        public Moteur(Moteur moteurACloner) : this(moteurACloner.puissanceEnChevaux, moteurACloner.estEntrainDeTourner)
        {
        }

        public int PuissanceEnChevaux { get => puissanceEnChevaux; }
        public bool EstEntrainDeTourner { get => estEntrainDeTourner; }

        public override string ToString()
        {
            return $"Moteur[puissanceEnChevaux : {this.puissanceEnChevaux}, estEntrainDeTourner : {this.EstEntrainDeTourner}]";
        }

        public bool Demarrer()
        {
            if (this.estEntrainDeTourner == false)
            {
                this.estEntrainDeTourner = true;
                return true;
            }
            return false;
        }

        public bool Arreter()
        {
            if (this.estEntrainDeTourner == true)
            {
                this.estEntrainDeTourner = false;
                return true;
            }
            return false;
        }

        public bool EntrainerRoues(Roue roueAvantDroite, Roue roueAvantGauche)
        {
            if (roueAvantDroite.Tourne() && roueAvantGauche.Tourne())
            {
                return true;
            }
            return false;
        }
    }
}
