using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepi
{
    public class Papillon : EtapeLepidoptere
    {
        private string couleur;

        public Papillon()
        {
            this.couleur = "bleu";
        }

        public string Couleur { get => couleur; }

        public override string ToString()
        {
            return $"Papillon [couleur : {this.couleur}]";
        }

        public override string SeNourrir()
        {
            return "Le Lepidoptere(Papillon) se nourrit de nectar.";
        }

        public override string SeDeplacer()
        {
            return "Le Lepidoptere(Papillion) vole.";
        }

        public override EtapeLepidoptere SeTransformer()
        {
            Console.WriteLine("Le Lepidoptere(Papillon) est l'étape finale !");
            return this;
        }
    }
}
