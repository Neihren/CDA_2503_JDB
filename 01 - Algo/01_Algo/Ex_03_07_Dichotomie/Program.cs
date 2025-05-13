using System.ComponentModel.DataAnnotations;

namespace Ex_03_07_Dichotomie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listePrenom = { "agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie" };
            string prenom;

            Console.Write("Quel est le prénom recherché ? ");
            prenom = Console.ReadLine();
            int position = Dichotomie(listePrenom, prenom);
            if (position != 0)
            {
                Console.WriteLine("Le prenom " + prenom + " se trouve à la position " + position);
            }
            else
            {
                Console.WriteLine("Le prenom " + prenom + " n'est pas dans la table");
            }
        }

        static int Dichotomie(String[] _tableau, string _prenom)
        {
            int gauche = 0;
            int droite = _tableau.Length - 1;

            while (gauche <= droite)
            {
                int milieu = (gauche + droite) / 2;
                int comparaison = string.Compare(_prenom, _tableau[milieu], StringComparison.CurrentCultureIgnoreCase);
                if (comparaison == 0)
                {
                    return milieu + 1;
                }
                else if (comparaison < 0)
                {
                    droite = milieu - 1;
                }
                else
                {
                    gauche = milieu + 1;
                }
            }
            return 0;
        }
    }
}
