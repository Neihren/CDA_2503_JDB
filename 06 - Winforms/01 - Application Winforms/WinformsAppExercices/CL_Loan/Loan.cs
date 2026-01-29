namespace CL_Loan
{
    public class Loan
    {
        private string name;
        private int amount;
        private int length;
        private double rate;
        private int frequency;

        public Loan()
        {
            this.name = "";
            this.amount = 0;
            this.length = 1;
            this.rate = 0.07d;
            this.frequency = 1;
        }
        
        public Loan(string name, int amount, int length, float rate, int frequency)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                this.name = "";
            }
            else
            {
                this.name = name;
            }
            this.amount = amount;
            this.length = length;
            this.rate = rate;
            this.frequency = frequency;
        }

        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Length { get => length; set => length = value; }
        public double Rate { get => rate; set => rate = value; }
        public int Frequency { get => frequency; set => frequency = value; }

        /// <summary>
        /// Calcule le montant de l'échéance périodique (mensualité, annuité, etc.) selon la fréquence et le taux définis.
        /// </summary>
        /// <returns>
        /// Le montant du remboursement (double). 
        /// Retourne 0 si le montant du capital n'est pas positif.
        /// </returns>
        /// <remarks>
        /// Le calcul utilise la formule classique des annuités constantes :
        ///     R = C * (t / (1 - (1 + t)^-n))
        /// où 't' est le taux ajusté à la période (Taux annuel / 12 * Fréquence).
        /// </remarks>
        public double CalcRemb()
        {
            if (this.amount > 0)
            {
                double monthlyRate = this.rate / 12 * this.frequency;
                double remb = this.amount * (monthlyRate / (1 - Math.Pow(1 + monthlyRate, -NbRemb())));
                return remb;
            }
            return 0;
        }

        /// <summary>
        /// Calcule le nombre total de remboursements (échéances) nécessaires pour solder le prêt.
        /// </summary>
        /// <returns>
        /// Le nombre d'échéances, obtenu en divisant la durée totale (en mois) par la fréquence de remboursement (en mois).
        /// </returns>
        public int NbRemb()
        {
            return this.Length / this.Frequency;
        }
    }
}
