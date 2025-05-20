namespace Lepi
{
    public class Lepidoptere
    {
        private string espece;
        private EtapeLepidoptere etapeLepidotere;

        public Lepidoptere(string espece, double tailleChenille)
        {
            this.espece = espece;
            this.etapeLepidotere = new Chenille(tailleChenille);
        }

        public string Espece { get => espece; }
        public EtapeLepidoptere EtapeLepidotere1 { get => etapeLepidotere; }

        public override string ToString()
        {
            return $"Lepidoptere [espece : {this.Espece}, EtapeLepidoptere : {this.EtapeLepidotere1}]";
        }
    }

    public abstract class EtapeLepidoptere
    {
        public abstract void SeDeplacer();
        public abstract EtapeLepidoptere SeTransformer();
    }

    public class Chenille : EtapeLepidoptere
    {
        private double tailleEnCM;

        public double TailleEnCM { get => tailleEnCM; }

        public Chenille(double tailleEnCM)
        {
            this.tailleEnCM = tailleEnCM;
        }

        public override string ToString()
        {
            return $"Chenille [tailleEnCM : {this.tailleEnCM}]";
        }

        public void SeNourrir()
        {
            // Comment elle mange
        }
        public override void SeDeplacer()
        {
            // Déplacement de la chenille en rampant
        }

        public override EtapeLepidoptere SeTransformer()
        {
            // Passe à l'étape Chrysalide
            return new Chrysalide(10);
        }
    }
    public class Chrysalide : EtapeLepidoptere
    {
        private int tempsChrysalideEnJours;

        public Chrysalide(int tempsChrysalideEnJours)
        {
            this.tempsChrysalideEnJours = tempsChrysalideEnJours;
        }

        public int TempsChrysalideEnJours { get => tempsChrysalideEnJours; }

        public override string ToString()
        {
            return $"Chrysalide [tempsChrysalideEnJours : {this.tempsChrysalideEnJours}]";
        }

        public override void SeDeplacer()
        {
            // Ne se déplace pas
        }

        public override EtapeLepidoptere SeTransformer()
        {
            // La chrysalide se développe en papillion
            return new Papillion("bleu");
        }
    }
    public class Papillion : EtapeLepidoptere
    {
        private string couleur;

        public Papillion(string couleur)
        {
            this.couleur = couleur;
        }

        public string Couleur { get => couleur; }

        public override string ToString()
        {
            return $"Papillion [couleur : {this.couleur}]";
        }

        public override void SeDeplacer()
        {
            // Le déplacement du papillion en volant ou rampant
        }

        public override EtapeLepidoptere SeTransformer()
        {
            // Il meurt ?
            return null;
        }
    }
}
