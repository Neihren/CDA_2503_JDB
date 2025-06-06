using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_421
{
    public class Manche
    {
        private De[] les3Des;

        public Manche()
        {
            this.les3Des = new De[3];
        }

        public void JeterLes3Des()
        {
            this.les3Des[0] = new De().LancerDe();
        }
    }
}
