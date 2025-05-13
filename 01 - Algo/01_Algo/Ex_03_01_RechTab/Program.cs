using System.Runtime.CompilerServices;

namespace Ex_03_01_RechTab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 6, 9, 16, 18, 24, 25, 27, 31, 45 };
            int searchedNb = 12;
            int index = 0
            bool nbFound = false;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == searchedNb)
                {
                    nbFound = true;
                    index = i;
                }
            }

            if (nbFound)
                Console.WriteLine(searchedNb + " fait bien parti de la liste de nombre à la position " + index);
            else
                Console.WriteLine("Non trouvé");
        }
    }
}
