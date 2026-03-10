using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Repertoire
{
    public class Fichier : Composant
    {
        public Fichier(string nom) : base(nom)
        {
            this.nom = nom;
        }

        public override void Repertorie()
        {
            throw new NotImplementedException();
        }

        public override string Formate(int ind)
        {
            throw new NotImplementedException();
        }
    }
}
