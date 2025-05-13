namespace Ex_01_02_AireVolume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            double area;
            double volume;
            Console.WriteLine("Veuillez entrer le rayon de la sphère : ");
            radius = int.Parse(Console.ReadLine());
            area = 4 * Math.PI * Math.Pow(radius,2);
            volume = 4 / 3d * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine("Pour un rayon de " + radius + " l'aire de la sphère est de " + area + " et son volume " + volume);
        }
    }
}
