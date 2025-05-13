using System.Reflection.Metadata.Ecma335;

namespace Ex_Final_PGCDv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Saisir un premier nombre : ");
            int nb1 = int.Parse(Console.ReadLine());
            Console.Write("Saisir un deuxième nombre : ");
            int nb2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Le PGCD de " + nb1 + " et " + nb2 + " est " + PGCD(nb1, nb2));
        }

        public static int PGCD(int _n, int _m)
        {
            return (_m == 0) ? _n : PGCD(_m, _n % _m);
        }
    }
}
