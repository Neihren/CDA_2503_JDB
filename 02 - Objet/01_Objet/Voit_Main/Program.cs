using Voit;

namespace Voit_Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture("Cupra", 120, 17, true);
            Console.WriteLine(v1.ToString());
            v1.Demarrer();
            Console.WriteLine(v1.ToString());
            v1.Avancer();
            Console.WriteLine(v1.ToString());
            v1.Arreter();
            Console.WriteLine("v1");
            Console.WriteLine(v1.ToString());
            Voiture v2 = new Voiture(v1);
            Console.WriteLine("v2 clone v1");
            Console.WriteLine(v2.ToString());
        }
    }
}
