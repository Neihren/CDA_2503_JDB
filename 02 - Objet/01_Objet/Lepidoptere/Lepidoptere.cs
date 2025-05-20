namespace Lepi
{
    public class Lepidoptere
    {
        private string espece;
        private EtapeLepidoptere etapeLepidotere;

        public Lepidoptere(string espece)
        {
            this.espece = espece;
            this.etapeLepidotere = new Chenille();
        }

        public string Espece { get => espece; }
        public EtapeLepidoptere EtapeLepidotere1 { get => etapeLepidotere; }

        public override string ToString()
        {
            return $"Lepidoptere [espece : {this.Espece}, EtapeLepidoptere : {this.EtapeLepidotere1}]";
        }

        public string SeNourrir()
        {
            return etapeLepidotere.SeNourrir();
        }

        public string SeDeplacer()
        {
            return etapeLepidotere.SeDeplacer() ;
        }
        
        public void SeTransformer()
        {
            this.etapeLepidotere = etapeLepidotere.SeTransformer();
        }
    }
}
