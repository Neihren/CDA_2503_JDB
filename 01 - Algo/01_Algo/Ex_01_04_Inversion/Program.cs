namespace Ex_01_04_Inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Donner un premier nombre : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Donner un deuxieme nombre : ");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Le premier nombre est maintenant : " + a);
            Console.WriteLine("Le deuxième nombre est maintenant : " + b);
        }
    }
}
