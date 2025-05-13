namespace Tp_Emprunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tauxInteretAnnuel;   // taux de l'interet annuel 
            int nbrAnneeRbmt;           // nombre d'année de remboursement
            double capitalEmprunte;     // capital emprunté
            double tauxInteretMensuel;  // taux d'intérêt mensuel = tauxInteretAnnuel / 12
            double mensualite;          // mensualité constante à rembourser
            int mois;                   // nombre de mois de la période
            int interetsMensuel;        // intérets du mois courant
            int amortissementMois;      // montant de l'amortissement du capital pour le mois courant
            double quotient;            // quotient



            tauxInteretAnnuel = 0.06;
            capitalEmprunte = 10000;
            mois = 36;

            tauxInteretMensuel = tauxInteretAnnuel / 12;
            quotient = (1 - Math.Pow(1 + tauxInteretMensuel, - mois));
            mensualite = capitalEmprunte * tauxInteretMensuel / quotient;


            double[] capitalRestant = new double[mois];
            double[] partCapital = new double[mois];
            double[] partInteret = new double[mois];


            capitalRestant[0] = capitalEmprunte;
            partCapital[0] = 0;
            partInteret[0] = 0;
            for (int i = 1; i < mois; i++)
            {
                partInteret[i] = capitalRestant[i - 1] * tauxInteretMensuel;
                partCapital[i] = mensualite - partInteret[i];
                capitalRestant[i] = capitalRestant[i - 1] - partCapital[i];
            }


            Console.WriteLine("Mensualités constantes : " + mensualite);

            Console.WriteLine(" +-------------+--------------+--------------+--------------------+------------+");
            Console.WriteLine(" | Numéro Mois | Part Intérêt | Part Capital | Capital Restant du | Mensualité |");
            Console.WriteLine(" +-------------+--------------+--------------+--------------------+------------+");
            for (int i = 0; i < mois; i++)
            {
                String display = "";
                display += Spaces(i, 12) + i;
                display += Spaces((int)(partInteret[i] + 1) * 100, 12) + partInteret[i].ToString("0.00");
                display += Spaces((int)(partCapital[i] + 1) * 100, 12) + partCapital[i].ToString("0.00");
                display += Spaces((int)(capitalRestant[i] + 1) * 100, 18) + capitalRestant[i].ToString("0.00");
                display += Spaces((int)(mensualite + 1) * 100, 10) + mensualite.ToString("0.00") + " |";
                Console.WriteLine(display);
            }
            Console.WriteLine(" +-------------+--------------+--------------+--------------------+------------+");

        }

        public static string Spaces(int _length, int _limit)
        {
            string spaces = " |";
            for (int j = _length.ToString().Length; j < _limit; j++)
            {
                spaces += " ";
            }
            return spaces;
        }
    }
}
