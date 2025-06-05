namespace ClassLibrary_Compte
{
    public class Compte
    {
        private int numeroUnique;
        private string nomProprietaire;
        private decimal solde;
        private decimal decouvertAutorise;
        private static int _counter;

        public Compte(string nomProprietaire, decimal decouvertAutorise)
        {

                if (decouvertAutorise > 0)
                {
                    throw new ArgumentException("Le découvert autorisé doit être un nombre négatif");
                }
                else
                {
                    this.numeroUnique = Interlocked.Increment(ref _counter);
                    this.nomProprietaire = nomProprietaire;
                    this.solde = 0;
                    this.decouvertAutorise = decouvertAutorise;
                }
 
        }

        public override string ToString()
        {
            return $"Compte[numeroUnique : {this.numeroUnique}, nomProprietaire : {this.nomProprietaire}, solde : {this.solde}, decouvertAutorise : {decouvertAutorise}]";
        }

        public void Crediter(decimal montantACrediter)
        {
            this.solde += montantACrediter;
        }

        public bool Debiter(decimal montantADebiter)
        {
            if (this.solde - montantADebiter < decouvertAutorise)
            {
                return false;
            }
            this.solde -= montantADebiter;
            return true;
        }

        public bool TransfererA(Compte compteDestinataire, decimal montantATransferer)
        {
            if(this.Debiter(montantATransferer))
            {
                compteDestinataire.Crediter(montantATransferer);
                return true;
            }
            return false;
        }

        public bool ComparerSuperieur(Compte compteAComparer)
        {
            return (this.solde >  compteAComparer.solde);
        }

    }
}
