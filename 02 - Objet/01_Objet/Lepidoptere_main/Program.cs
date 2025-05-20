using Lepi;

namespace Lepidoptere_main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere papilusion = new Lepidoptere("Azuré");

            Console.WriteLine(papilusion.ToString());
            Console.WriteLine(papilusion.SeNourrir());
            Console.WriteLine(papilusion.SeDeplacer());
            papilusion.SeTransformer();
            Console.WriteLine(papilusion.ToString());
            Console.WriteLine(papilusion.SeNourrir());
            Console.WriteLine(papilusion.SeDeplacer());
            papilusion.SeTransformer();
            Console.WriteLine(papilusion.ToString());
            Console.WriteLine(papilusion.SeNourrir());
            Console.WriteLine(papilusion.SeDeplacer());
            papilusion.SeTransformer();
        }
    }
}
