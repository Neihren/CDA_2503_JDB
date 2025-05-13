namespace Financier
{
    public class Credit
    {
        // Attributs
        private double tauxInteretMensuel;
        private double capitalEmprunte;
        private int nbMois;

        // Propriétés permettant l'accessibilité/modification des attributs
        public double TauxInteretMensuel { get => tauxInteretMensuel; set => tauxInteretMensuel = value; }
        public double CapitalEmprunte { get => capitalEmprunte; set => capitalEmprunte = value; }
        public int NbMois { get => nbMois; set => nbMois = value; }

        // Constructeur surchargé
        public Credit(double tauxInteretAnnuel, double capitalEmprunte, int nbMois)
        {
            this.tauxInteretMensuel = tauxInteretAnnuel / 1200;
            this.capitalEmprunte = capitalEmprunte;
            this.nbMois = nbMois;
        }
        
        // Méthodes de la classe (Elles font les traitement avec ou sans paramètres. Procédures ne retournent rien contrairement au fonctions)
        public double calculMensualite()
        {
            double quotient = (1 - Math.Pow(1 + this.TauxInteretMensuel, -this.NbMois));
            double mensualite = this.CapitalEmprunte * this.TauxInteretMensuel / quotient;
            return Math.Round(mensualite, 2);
        }

        public void tabAmortissement()
        {
            double[] capitalRestant = new double[this.NbMois];
            double[] partCapital = new double[this.NbMois];
            double[] partInteret = new double[this.NbMois];
            double mensualite = calculMensualite();

            capitalRestant[0] = CapitalEmprunte;
            partCapital[0] = 0;
            partInteret[0] = 0;
            for (int i = 1; i < this.NbMois; i++)
            {
                partInteret[i] = capitalRestant[i - 1] * this.TauxInteretMensuel;
                partCapital[i] = calculMensualite() - partInteret[i];
                capitalRestant[i] = capitalRestant[i - 1] - partCapital[i];
            }
            Console.WriteLine($"\nMensualités constantes : {mensualite}\n");

            Console.WriteLine(" +-------------+--------------+--------------+--------------------+------------+");
            Console.WriteLine(" | Numéro Mois | Part Intérêt | Part Capital | Capital Restant du | Mensualité |");
            Console.WriteLine(" +-------------+--------------+--------------+--------------------+------------+");
            for (int i = 0; i < this.NbMois; i++)
            {
                String display = "";
                display += Spaces(i+1, 12) + (i+1);
                display += Spaces((int)(partInteret[i]), 10) + partInteret[i].ToString("0.00");
                display += Spaces((int)(partCapital[i]), 10) + partCapital[i].ToString("0.00");
                display += Spaces((int)(capitalRestant[i]), 16) + capitalRestant[i].ToString("0.00");
                display += Spaces((int)(calculMensualite()), 8) + mensualite.ToString("0.00") + " |";
                Console.WriteLine(display);
            }
            Console.WriteLine(" +-------------+--------------+--------------+--------------------+------------+");

            Console.WriteLine("\nCoût total du crédit : " + AfficherCoutTotal(partInteret).ToString("0.00"));
        }

        private string Spaces(int _length, int _limit)
        {
            string spaces = " |";
            for (int j = _length.ToString().Length; j < _limit; j++)
            {
                spaces += " ";
            }
            return spaces;
        }

        public override string ToString()
        {
            string descriptions = $" : Montant du crédit : {this.CapitalEmprunte}\nTaux effectif global : {this.TauxInteretMensuel}\nDurée de remboursement : {this.NbMois}";
            return base.ToString() + descriptions;
        }

        public double AfficherCoutTotal(double[] partInteret)
        {
            double coutTotal = 0;
            foreach (double i in partInteret)
            {
                coutTotal += i;
            }
            return coutTotal;
        }
    }
}
