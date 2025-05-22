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

        public Roue()
        {
            this.tailleEnPouces = 17;
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
