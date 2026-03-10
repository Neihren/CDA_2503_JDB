namespace CL_EditeurTexte
{
    // Receiver (Document texte)
    public class Document
    {
        private string texte;

        public Document()
        {
            this.texte = "";
        }

        public string Texte { get => texte;/* set => texte = value;*/ }

        public void Inserer(int position, string texteAInserer)
        {
            texte = texte.Insert(position, texteAInserer);
        }

        public void Supprimer(int position, int longueur)
        {
            texte = texte.Remove(position, longueur);
        }

        public string AfficherTexte()
        {
            return texte;
        }
    }
}
