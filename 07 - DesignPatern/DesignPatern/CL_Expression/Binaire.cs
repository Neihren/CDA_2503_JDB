using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Expression
{
    public abstract class Binaire : Expression
    {
        protected Expression op1;
        protected Expression op2;

        public Binaire(Expression op1, Expression op2):base()
        {
            this.op1 = op1;
            this.op2 = op2;
        }
    }
}
