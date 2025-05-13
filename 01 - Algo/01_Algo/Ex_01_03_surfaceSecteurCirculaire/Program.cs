namespace Ex_01_03_surfaceSecteurCirculaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir le rayon du cercle et son angle.");
            Console.Write("Rayon : ");
            double radius = double.Parse(Console.ReadLine());
            Console.Write("Angle : ");
            double angle = double.Parse(Console.ReadLine());
            double sectorArea = Math.PI * Math.Pow(radius, 2) * angle / 360d;
            Console.WriteLine("L'aire du secteur circulaire = " + sectorArea);
        }
    }
}
