using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Figure
{
    public class Cercle : Forme
    {
        private int rayon;

        public Cercle(int rayon, int x, int y) : base (x, y)
        {
            this.rayon = rayon;
        }

        public int Rayon { get => rayon; }

        public override void Accept(IVisiteurDeForme visiteur)
        {
            visiteur.Visit(this);
        }
    }
}
