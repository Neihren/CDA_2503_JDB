using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepi
{
    public class Papillion : EtapeLepidoptere
    {
        private string couleur;

        public Papillion()
        {
            this.couleur = "bleu";
        }

        public string Couleur { get => couleur; }

        public override string ToString()
        {
            return $"Papillion [couleur : {this.couleur}]";
        }

        public override string SeNourrir()
        {
            return "Le Lepidoptere(Papillion) se nourrit de nectar.";
        }

        public override string SeDeplacer()
        {
            return "Le Lepidoptere(Papillion) vole.";
        }

        public override EtapeLepidoptere SeTransformer()
        {
            Console.WriteLine("Le Lepidoptere(Papillion) meurt !");
            return null;
        }
    }
}
