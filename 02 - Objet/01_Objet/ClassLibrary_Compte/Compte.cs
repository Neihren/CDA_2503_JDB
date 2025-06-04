namespace ClassLibrary_Compte
{
    public class Compte
    {
        private int numeroUnique;
        private int nomProprietaire;
        private decimal solde;
        private decimal decouvertAutorise;

        public Compte(int numeroUnique, int nomProprietaire, decimal solde, decimal decouvertAutorise)
        {
            this.numeroUnique = numeroUnique;
            this.nomProprietaire = nomProprietaire;
            this.solde = solde;
            this.decouvertAutorise = decouvertAutorise;
        }

        public override string ToString()
        {
            return $"Compte[numeroUnique : {this.numeroUnique}, nomProprietaire : {this.nomProprietaire}, solde : {this.solde}, decouvertAutorise : {decouvertAutorise}]";
        }

        public void Crediter(decimal montantACrediter)
        {
            this.solde += montantACrediter;
        }

        public bool Debiter(decimal montantACrediter)
        {
            this.solde -= montantACrediter;
            return true ;
        }

    }
}
