namespace Voit
{
    public class Voiture
    {
        private string modele;
        private Moteur moteur;
        private Roue[] sesRoues;
        private Roue roueSecours;

        public Voiture(string modele, bool roueSecours)
        {
            this.modele = modele;
            this.moteur = new Moteur();
            this.sesRoues = new Roue[4];
            if (roueSecours)
            {
                this.roueSecours = new Roue();
            }
            else
            {
                this.roueSecours = null;
            }
        }

        public string Modele { get => modele; }
        public Moteur Moteur { get => moteur; }
        public Roue[] SesRoues { get => sesRoues; }
        public Roue RoueSecours { get => roueSecours; }

        public override string ToString()
        {
            return $"Voiture[modele : {this.modele}, moteur : {this.moteur}, sesRoues : {this.sesRoues}, roueSecours {this.roueSecours}";
        }

        public string Demarrer()
        {
            moteur.Demarrer();
            return "La voiture est démarrée";
        }

        public string Arreter()
        {
            moteur.Arreter();
            return "La voiture est arrêtée";
        }

        public string Avancer()
        {
            foreach (Roue roue in sesRoues)
            {
                roue.tourne();
            }
            return "La voiture avance";
        }
    }
}
