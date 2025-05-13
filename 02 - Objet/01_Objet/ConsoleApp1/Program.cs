using Bouteilles;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille b1 = new Bouteille(false, 1, 0.5m);
            Console.WriteLine(b1.ToString());
            b1.Open();
            b1.Fill(1m);
            Console.WriteLine(b1.ToString());
        }
    }
}
