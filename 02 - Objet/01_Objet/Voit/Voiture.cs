namespace Voit
{
    public class Voiture
    {
        private string modele;
        private Moteur moteur;
        private Roue[] sesRoues;
        private Roue? roueSecours;

        public Voiture(string modele, int moteurPuissanceEnChevaux, int rouesTailleEnpouces, bool roueSecours)
        {
            this.modele = modele;
            this.moteur = new Moteur(moteurPuissanceEnChevaux);
            this.sesRoues = new Roue[4]{new Roue(rouesTailleEnpouces),new Roue(rouesTailleEnpouces),new Roue(rouesTailleEnpouces),new Roue(rouesTailleEnpouces)};
            if (roueSecours)
            {
                this.roueSecours = new Roue(rouesTailleEnpouces);
            }
            else
            {
                this.roueSecours = null;
            }
        }

        public Voiture() : this("", 0, 0, false)
        {
        }

        public Voiture(Voiture voitureACloner)
        {
            this.modele = voitureACloner.modele;
            this.moteur = voitureACloner.moteur;
            this.sesRoues = voitureACloner.sesRoues;
            this.roueSecours = voitureACloner.roueSecours;
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
                roue.Tourne();
            }
            return "La voiture avance";
        }
    }
}
