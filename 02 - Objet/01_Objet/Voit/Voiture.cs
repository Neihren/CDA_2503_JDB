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
            this.moteur = new Moteur(moteurPuissanceEnChevaux, false);
            this.sesRoues = new Roue[4];
            for (int i = 0; i < sesRoues.Length; i++)
            {
                sesRoues[i] = new Roue(rouesTailleEnpouces, false);
            }
            if (roueSecours)
            {
                this.roueSecours = new Roue(rouesTailleEnpouces, false);
            }
            else
            {
                this.roueSecours = null;
            }
        }

        private Voiture(string modele, Moteur moteur, Roue[] sesRoues, Roue? roueSecours)
        {
            this.modele = modele;
            this.moteur = new Moteur();
            this.sesRoues = new Roue[4];
            for (int i = 0; i < this.sesRoues.Length; i++)
            {
                this.sesRoues[i] = new Roue();
            }
            this.roueSecours = roueSecours;
        }

        public Voiture() : this("", new Moteur(), new Roue[4] { new Roue(),new Roue(),new Roue(),new Roue()},null)
        {
        }

        public Voiture(Voiture voitureACloner) : this(voitureACloner.modele, voitureACloner.moteur, voitureACloner.sesRoues, voitureACloner.roueSecours)
        {
            //this.modele = voitureACloner.modele;
            //this.moteur = voitureACloner.moteur;
            //this.sesRoues = voitureACloner.sesRoues;
            //this.roueSecours = voitureACloner.roueSecours;
        }

        public string Modele { get => modele; }
        public Moteur Moteur { get => moteur; }
        //public Roue this[int key]
        //{
        //    get => sesRoues[key];
        //}
        // public Roue[] SesRoues { get => sesRoues; }
        public Roue RoueSecours { get => roueSecours; }

        public override string ToString()
        {
            string voiture = $"Voiture[modele : {this.modele}, \n\tmoteur : {this.moteur},\n\tsesRoues : ";
            foreach (Roue roues in sesRoues)
            {
                voiture += $"\n\t\t{roues.ToString()},";
            }
            voiture += $"\n\troueSecours : \n\t\t{this.roueSecours}";
            return voiture;
        }

        public bool Demarrer()
        {

            return moteur.Demarrer();
        }

        public bool Arreter()
        {
            return moteur.Arreter();
        }

        public bool Avancer()
        {
            return this.moteur.EntrainerRoues(sesRoues[0], sesRoues[1]);
        }
    }
}
