namespace CL_Repertoire
{
    public abstract class Composant
    {
        protected string nom;
        protected int indentation;

        public Composant (string nom)
        {
            this.nom = nom;
        }

        public abstract void Repertorie();
        public abstract string Formate(int ind);
    }
}
