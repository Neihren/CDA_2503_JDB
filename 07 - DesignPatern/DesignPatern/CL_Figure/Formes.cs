using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace CL_Figure
{
    public class Formes : Forme
    {
        List<Forme> sesFormes;

        public Formes(int x, int y) : base(x, y)
        {
            sesFormes = new();
        }

        public void AjouterForme(Forme formeAAjouter)
        {
            sesFormes.Add(formeAAjouter);
        }

        public override void Accept(IVisiteurDeForme visiteur)
        {
            visiteur.Visit(this);
            foreach (Forme f in sesFormes)
            {
                f.Accept(visiteur);
            }
        }
    }
}
