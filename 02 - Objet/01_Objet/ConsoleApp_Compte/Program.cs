using ClassLibrary_Compte;

namespace ConsoleApp_Compte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            try
            {
                Compte c3 = new Compte("Sophie", 1000);
            }
            catch (Exception e)
            {
            }
            Compte c1 = new Compte("Sophie", -1000);
            Compte c2 = new Compte("Franck", -500);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());
            c1.Crediter(2000);
            result = c1.Debiter(4000);
            result = c1.Debiter(500);
            result = c1.TransfererA(c2, 6000);
            result = c1.TransfererA(c2, 200);
            result = c1.ComparerSuperieur(c2);

        }
    }
}
