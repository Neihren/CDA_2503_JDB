using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepi
{
    public class Chenille : EtapeLepidoptere
    {
        private double tailleEnCM;
        
        public Chenille()
        {
            this.tailleEnCM = 4;
        }
        
        public double TailleEnCM { get => tailleEnCM; }

        public override string ToString()
        {
            return $"Chenille [tailleEnCM : {this.tailleEnCM}]";
        }

        public override string SeNourrir()
        {
            return "Le Lepidoptere(Chenille) se nourrit de feuilles.";
        }

        public override string SeDeplacer()
        {
            return "Le Lepidoptere(Chenille) rampe.";
        }

        public override EtapeLepidoptere SeTransformer()
        {
            Console.WriteLine("Le Lepidoptere(Chenille) évolue en Chrysalide !");
            return new Chrysalide();
        }
    }
}
