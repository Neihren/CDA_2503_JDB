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

        public Moteur()
        {
            this.puissanceEnChevaux = 110;
            this.estEntrainDeTourner = false;
        }

        public int PuissanceEnChevaux { get => puissanceEnChevaux; }
        public bool EstEntrainDeTourner { get => estEntrainDeTourner; }

        public override string ToString()
        {
            return $"Moteur[puissanceEnChevaux : {this.puissanceEnChevaux}, estEntrainDeTourner : {this.EstEntrainDeTourner}]";
        }

        public string Demarrer()
        {
            this.estEntrainDeTourner = true;
            return "Le moteur tourne";
        }

        public string Arreter()
        {
            this.estEntrainDeTourner = false;

            return "Le moteur est à l'arrêt";
        }
    }
}
