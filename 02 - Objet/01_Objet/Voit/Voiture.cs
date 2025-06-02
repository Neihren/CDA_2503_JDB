namespace Voit
{
    public class Voiture
    {
        private string modele;
        private Moteur moteur;
        private Roue[] sesRoues;
        private Roue? saRoueSecours;

        public Voiture(string modele, int moteurPuissanceEnChevaux, int rouesTailleEnpouces, bool roueSecours)
        {
            this.modele = modele;
            this.moteur = new Moteur(moteurPuissanceEnChevaux);
            this.sesRoues = new Roue[4];
            for (int i = 0; i < sesRoues.Length; i++)
            {
                sesRoues[i] = new Roue(rouesTailleEnpouces);
            }
            if (roueSecours)
            {
                this.saRoueSecours = new Roue(rouesTailleEnpouces);
            }
            else
            {
                this.saRoueSecours = null;
            }
        }

        private Voiture(string modele, Moteur moteur, Roue[] sesRoues, Roue? roueSecours)
        {
            this.modele = modele;
            this.moteur = new Moteur(moteur);
            this.sesRoues = new Roue[4];
            for (int i = 0; i < this.sesRoues.Length; i++)
            {
                this.sesRoues[i] = new Roue(sesRoues[i]);
            }
            this.saRoueSecours = roueSecours;
        }

        public Voiture() : this("", new Moteur(), new Roue[4] { new Roue(),new Roue(),new Roue(),new Roue()},null)
        {
        }

        public Voiture(Voiture voitureACloner) : this(voitureACloner.modele, new Moteur(voitureACloner.moteur), new Roue[4] { new Roue(voitureACloner.sesRoues[0]), new Roue(voitureACloner.sesRoues[1]), new Roue(voitureACloner.sesRoues[2]), new Roue(voitureACloner.sesRoues[3]) }, new Roue(voitureACloner.saRoueSecours))
        {
        }

        public override string ToString()
        {
            string voiture = $"Voiture[modele : {this.modele}, \n\tmoteur : {this.moteur},\n\tsesRoues : ";
            foreach (Roue roues in sesRoues)
            {
                voiture += $"\n\t\t{roues.ToString()},";
            }
            voiture += $"\n\troueSecours : \n\t\t{this.saRoueSecours}";
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
