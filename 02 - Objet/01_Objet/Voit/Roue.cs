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

        public Roue(int tailleEnPouces)
        {
            this.tailleEnPouces = tailleEnPouces;
            this.entrainDeTourner = false;
        }

        public Roue() : this(0)
        {
            this.entrainDeTourner = false;
        }

        public Roue(Roue roueACloner) : this(roueACloner.tailleEnPouces)
        {
            this.entrainDeTourner = false;
        }

        public int TailleEnPouces { get => tailleEnPouces; }
        public bool EntrainDeTourner { get => entrainDeTourner; }

        public override string ToString()
        {
            return $"Roue[tailleEnPouces : {this.tailleEnPouces}, entrainDeTourner : {this.EntrainDeTourner}]";
        }

        public string Tourne()
        {
            this.entrainDeTourner = true;
            return "les roues tournent";
        }
    }
}
