using System.Collections;
using static Ex_TriABulle.Tritableau;

namespace Ex_TriABulle
{
    class Program
    {
        static void Main(string[] args)
        {
            Tritableau monObjet;
            int nbcase = 10;
            int[] tabNombres;
            string[] tabformations = new string[10];
            int[] tabEffectifs = new int[10];
            IComparer myComparer = new myReverserClass();

            Console.WriteLine(" le CRM : OFP veuillez saisir l'intitulé des formations du groupe Numerique et Industrie ");
            for (int i = 0; i < tabformations.Length; i++)
            {
                Console.WriteLine("Veuillez saisir le nom de la formation {0}/ {1} du tableau :", i + 1, nbcase);
                tabformations[i] = Console.ReadLine();

            }
            Console.WriteLine("veuillez saisir les effectifs par formation ");
            for (int i = 0; i < tabEffectifs.Length; i++)
            {
                Console.WriteLine("Veuillez saisir le nom de la formation {0}/ {1} du tableau :", i + 1, nbcase);
                tabEffectifs[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("veuilez trier les formations par effectifs stagiaires par ordre croissant!!");
            Array.Sort(tabEffectifs, tabformations);
            PrintKeysAndValues(tabformations, tabEffectifs);

            Console.WriteLine("Veuillez saisir le nombre de valeurs à intégrer au tableau :");
            nbcase = int.Parse(Console.ReadLine());
            tabNombres = new int[nbcase];
            for (int i = 0; i < tabNombres.Length; i++)
            {
                Console.WriteLine("Veuillez saisir le nombre numero {0}/ {1} du tableau :", i + 1, nbcase);
                tabNombres[i] = int.Parse(Console.ReadLine());
            }
            monObjet = new Tritableau();
            Console.WriteLine(" Tableau de nombre avant le tri:");
            monObjet.Affichertableau(tabNombres);
            monObjet.TrierTableauAsc(ref tabNombres);
            Console.WriteLine(" Tableau de nombre après le tri: critère croissant ");
            monObjet.Affichertableau(tabNombres);
        }
    }
    class Tritableau
    {
        public void TrierTableauAsc(ref int[] _montab)
        {
            int temp;
            bool permut;
            for (int i = 0; i < _montab.Length - 1; i++)
            {
                for (int j = i + 1; j < _montab.Length; j++)
                {
                    if (_montab[i] > _montab[j])
                    {
                        temp = _montab[j];
                        _montab[j] = _montab[i];
                        _montab[i] = temp;
                    }
                }
            }
        }

        public void Affichertableau(int[] _untab)
        {
            Console.Write("\n [ ");
            foreach (int element in _untab)
            {
                Console.Write(element + " ");
            }
            Console.Write("]\n");
        }
        public class myReverserClass : IComparer
        {

            // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
            int IComparer.Compare(Object x, Object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }
        }
        public static void PrintKeysAndValues(String[] myKeys, int[] myValues)
        {
            for (int i = 0; i < myKeys.Length; i++)
            {
                Console.WriteLine("   {0,-10}: {1}", myKeys[i], myValues[i]);
            }
            Console.WriteLine();
        }
    }
}
