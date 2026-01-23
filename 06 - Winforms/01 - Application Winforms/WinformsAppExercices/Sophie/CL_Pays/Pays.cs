namespace CL_Pays
{
    public class Pays
    {
        private string nom;

        public Pays(string nom)
        {
            this.nom = nom;
        }

        public string Nom { get => nom; set => nom = value; }
    }
}
