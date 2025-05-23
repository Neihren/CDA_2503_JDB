namespace Voit
{
    public class Voiture
    {
        private string modele;
        private Moteur moteur;
        private Roue[] sesRoues;
        private Roue? roueSecours;

        public Voiture(string modele, int moteurPuissanceEnChevaux,bool moteurTourne, int rouesTailleEnpouces,bool roueTourne, bool roueSecours)
        {
            this.modele = modele;
            this.moteur = new Moteur(moteurPuissanceEnChevaux, moteurTourne);
            this.sesRoues = new Roue[4];
            for (int i = 0; i < sesRoues.Length; i++)
            {
                sesRoues[i] = new Roue(rouesTailleEnpouces, roueTourne);
            }
            if (roueSecours)
            {
                this.roueSecours = new Roue(rouesTailleEnpouces, roueTourne);
            }
            else
            {
                this.roueSecours = null;
            }
        }

        public Voiture() : this("", 0, false, 0, false, false)
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
        public Roue this[int key]
        {
            get => sesRoues[key];
        }
       // public Roue[] SesRoues { get => sesRoues; }
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
