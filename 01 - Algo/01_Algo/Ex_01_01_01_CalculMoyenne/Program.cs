namespace Ex_01_01_01_CalculMoyenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a;
            int b;

            Console.WriteLine("Veuillez saisir un nombre entier a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir un nombre entier b : ");
            b = int.Parse(Console.ReadLine());
            // Casting au niveau float
            float avg = (float) (a + b) / 2;
            Console.Write("La moyenne de a et b est : " + avg);
            */
            Console.WriteLine("Programme de calcul de la moyenne de 2 nombres.");
            Console.WriteLine("Veuillez saisir 2 nombres séparés par un espace :");
            String nb = Console.ReadLine();
            String[] nbs = nb.Split(' ');
            Console.WriteLine("La moyenne de " + nbs[0] + " et " + nbs[1] + " est : " + (int.Parse(nbs[0]) + int.Parse(nbs[1])) / 2.0);
            
        }
    }
}
