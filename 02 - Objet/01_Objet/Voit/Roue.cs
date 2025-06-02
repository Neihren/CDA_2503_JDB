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

        private Roue(int tailleEnPouces, bool entrainDeTourner)
        {
            this.tailleEnPouces = tailleEnPouces;
            this.entrainDeTourner = entrainDeTourner;
        }

        public Roue (int tailleEnPouces)
        {
            this.tailleEnPouces = tailleEnPouces;
            this.entrainDeTourner = false;
        }

        public Roue() : this(0, false)
        {
        }

        public Roue(Roue roueACloner) : this(roueACloner.tailleEnPouces, roueACloner.entrainDeTourner)
        {
        }

        public override string ToString()
        {
            return $"Roue[tailleEnPouces : {this.tailleEnPouces}, entrainDeTourner : {this.entrainDeTourner}]";
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
