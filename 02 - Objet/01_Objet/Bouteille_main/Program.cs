using Bouteilles;
using System.Runtime.Intrinsics.X86;

namespace Bouteille_main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            Bouteille bDefault = new Bouteille();
            Bouteille bClassique = new Bouteille(true, 1, 0.5m);
            Bouteille bClone = new Bouteille(bClassique);
            Console.WriteLine(bDefault.ToString());


            // Constructeur exception 1 
            //Bouteille b2 = new Bouteille(false, -1, 1);
            //Bouteille b2 = new Bouteille(false, 1, -1);
            // Constructeur exception 2
            //Bouteille b2 = new Bouteille(false, 1, 2);


            result = bClassique.Open();
            result = bClassique.Close();
            result = bClassique.Close();
            result = bClassique.Open();

            result = bClassique.Empty();
            result = bClassique.Empty();
            result = bClassique.Fill();
            result = bClassique.Fill();

            //Empty exception 1
            //bClassique.Empty(-10)
            //Fill exception 1
            //bClassique.Fill(-10);

            result = bClassique.Empty(0.5m);
            result = bClassique.Empty(2);
            result = bClassique.Fill(0.5m);
            result = bClassique.Fill(10.5m);

            bClassique.Close();
            result = bClassique.Empty(0.5m);
            result = bClassique.Fill(0.5m);

            bClassique.Open();
            result = bClassique.Empty(0.5m);
            result = bClassique.Fill(0.5m);
        }
    }
}
