using ClassLibrary_Point;

namespace ConsoleApp_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point();
            a.Deplacer(12, 15);
            Point b = a.SymetrieBissectrice();
            Point c = a.SymetrieOrigine();
            Point d = a.SymetrieOrdonnee();
            Point e = a.SymetrieAbscisse();
        }
    }
}
