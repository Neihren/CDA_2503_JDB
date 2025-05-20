using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepi
{
    public abstract class EtapeLepidoptere
    {
        public abstract string SeNourrir();
        public abstract string SeDeplacer();
        public abstract EtapeLepidoptere SeTransformer();
    }
}
