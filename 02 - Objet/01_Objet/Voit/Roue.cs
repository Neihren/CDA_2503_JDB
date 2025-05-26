using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voit
{
    public class Roue
    {
        private int tailleEnPouces;
        private bool entrainDeTourner;

        public Roue(int tailleEnPouces, bool entrainDeTourner)
        {
            this.tailleEnPouces = tailleEnPouces;
            this.entrainDeTourner = entrainDeTourner;
        }

        public Roue() : this(0, false)
        {
        }

        public Roue(Roue roueACloner) : this(roueACloner.tailleEnPouces, roueACloner.entrainDeTourner)
        {
        }

        public int TailleEnPouces { get => tailleEnPouces; }
        public bool EntrainDeTourner { get => entrainDeTourner; }

        public override string ToString()
        {
            return $"Roue[tailleEnPouces : {this.tailleEnPouces}, entrainDeTourner : {this.EntrainDeTourner}]";
        }

        public bool Tourne()
        {
            if (this.entrainDeTourner == false)
            {
                this.entrainDeTourner = true;
                return true;
            }
            return false;
        }
    }
}
