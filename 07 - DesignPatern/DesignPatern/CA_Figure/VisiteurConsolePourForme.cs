using CL_Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Figure
{
    public class VisiteurConsolePourForme : IVisiteurDeForme
    {
        public void Visit(Rectangle r)
        {
            Console.WriteLine($"Je suis un rectangle d'origine (x, y) = ({r.X}, {r.Y}), de longueur {r.Longueur} et largeur {r.Largeur}");
        }

        public void Visit(Cercle c)
        {
            Console.WriteLine($"Je suis un cercle d'origine (x, y) = ({c.X}, {c.Y}) et de rayon {c.Rayon}");
        }

        public void Visit(Formes f)
        {
            string listeFormes;
            listeFormes = $"Je suis une liste de formes d'origine (x, y) = ({f.X}, {f.Y}).\n"
                        + $"Mes formes sont :\n";
            Console.WriteLine(listeFormes);
        }
    }
}
