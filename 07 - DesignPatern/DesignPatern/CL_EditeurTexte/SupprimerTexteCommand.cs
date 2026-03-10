using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_EditeurTexte
{
    // Commande concrète pour supprimer du texte
    public class SupprimerTexteCommand : ICommand
    {
        private readonly Document document;
        private readonly int position;
        private readonly int longueur;
        private string texteSupprime;

        public SupprimerTexteCommand(Document document, int position, int longueur)
        {
            this.document = document;
            this.position = position;
            this.longueur = longueur;
            this.texteSupprime = "";
        }

        public void Execute()
        {
            texteSupprime = document.Texte.Substring(position, longueur);
            document.Supprimer(position, longueur);
        }

        public void Undo()
        {
            document.Inserer(position, texteSupprime);
        }
    }
}
