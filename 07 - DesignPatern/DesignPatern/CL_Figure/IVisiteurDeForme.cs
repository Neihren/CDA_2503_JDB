using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Figure
{
    public interface IVisiteurDeForme
    {
        void Visit(Rectangle rectangle);
        void Visit(Cercle cercle);
        void Visit(Formes formes);
    }
}
