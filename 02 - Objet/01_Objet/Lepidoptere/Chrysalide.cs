using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepi
{
    public class Chrysalide : EtapeLepidoptere
    {
        private int tempsChrysalideEnJours;

        public Chrysalide()
        {
            this.tempsChrysalideEnJours = 10;
        }

        public int TempsChrysalideEnJours { get => tempsChrysalideEnJours; }

        public override string ToString()
        {
            return $"Chrysalide [tempsChrysalideEnJours : {this.tempsChrysalideEnJours}]";
        }

        public override string SeNourrir()
        {
            return "Le Lepidoptere(Chrysalide) ne se nourrit pas.";
        }

        public override string SeDeplacer()
        {
            return "Le Lepidoptere(Chrysalide) ne se déplace pas.";
        }

        public override EtapeLepidoptere SeTransformer()
        {
            Console.WriteLine("Le Lepidoptere(Chrysalide) évolue en Papillion !");
            return new Papillon();
        }
    }
}
