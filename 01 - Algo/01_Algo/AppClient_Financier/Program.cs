using Financier;

namespace AppClient_Financier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tauxAnnuel;
            double montantEmprunte;
            int nbMois;
            List<Credit> banqueRevolut = new List<Credit>();

            Console.Write("Quel montant souhaitez-vous Emprunter ? ");
            montantEmprunte = double.Parse(Console.ReadLine());
            Console.Write("A quel taux sera l'emprunt ? ");
            tauxAnnuel = double.Parse(Console.ReadLine());
            Console.Write("Sur combiens de mois ? ");
            nbMois = int.Parse(Console.ReadLine());

            Credit cred1 = new Credit(tauxAnnuel, montantEmprunte, nbMois);
            Credit cred2 = new Credit(5.4, 15000, 60);
            Credit cred3 = new Credit(5.2, 8000, 48);
            Credit cred4 = new Credit(4.8, 12000, 84);

            banqueRevolut.Add(cred1);
            banqueRevolut.Add(cred2);
            banqueRevolut.Add(cred3);
            banqueRevolut.Add(cred4);

            List<Credit> creditSup = banqueRevolut.FindAll(elementCredit => elementCredit.CapitalEmprunte >= 10000 && elementCredit.TauxInteretMensuel >= 0.004);
            foreach (Credit credit in creditSup)
            {
                Console.WriteLine(credit.ToString());
            }
            cred1.tabAmortissement();
        }
    }
}