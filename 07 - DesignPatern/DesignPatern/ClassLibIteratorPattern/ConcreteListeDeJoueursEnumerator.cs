using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ClassLibIteratorPattern
{
    public class ConcreteListeDeJoueursEnumerator : IEnumerator
    {

        private ListeDeJoueurs leConcreteAggregate;
        private int positionCourante = -1;

        public ConcreteListeDeJoueursEnumerator(ListeDeJoueurs _leConcreteAggregate)
        {
            leConcreteAggregate = _leConcreteAggregate;
        }

        public bool MoveNext()
        {
            bool ret = false;

            if (positionCourante < leConcreteAggregate.Count - 1)
            {
                positionCourante = positionCourante + 1;
                ret = true;
            }
            else
            {
                ret = false;
            }
            return ret;
        }

        public void Reset()
        {
            positionCourante = -1;
        }

        public object Current
        {
            get
            {
                if (positionCourante == -1)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    return leConcreteAggregate[positionCourante];
                }
            }
        }
    }
}
