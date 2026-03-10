using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Figure
{
    public class Rectangle : Forme
    {
        private int longueur;
        private int largeur;

        public Rectangle(int longueur, int largeur, int x, int y) : base(x, y)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public int Longueur { get => longueur; }
        public int Largeur { get => largeur; }

        public override void Accept(IVisiteurDeForme visiteur)
        {
            visiteur.Visit(this);
        }
    }
}
