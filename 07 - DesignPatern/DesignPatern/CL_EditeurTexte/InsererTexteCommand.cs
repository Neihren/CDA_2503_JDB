using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_EditeurTexte
{
    // Commande concrète pour inserer du texte
    public class InsererTexteCommand : ICommand
    {
        private readonly Document document;
        private readonly int position;
        private readonly string texteAInserer;

        public InsererTexteCommand(Document document, int position, string texteAInserer)
        {
            this.document = document;
            this.position = position;
            this.texteAInserer = texteAInserer;
        }

        public void Execute()
        {
            document.Inserer(position, texteAInserer);
        }

        public void Undo()
        {
            document.Supprimer(position, texteAInserer.Length);
        }
    }
}
