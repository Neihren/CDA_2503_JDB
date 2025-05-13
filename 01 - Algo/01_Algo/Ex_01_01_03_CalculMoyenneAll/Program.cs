namespace Ex_01_01_03_CalculMoyenneAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.WriteLine("Programme de calcul de la moyenne de tous les nombres.");
            Console.WriteLine("Veuillez saisir vos nombres séparés par des espaces :");
            String[] nbs = Console.ReadLine().Split(' ');
            foreach (String s in nbs)
            {
                sum += int.Parse(s);
            }
            Console.WriteLine("La moyenne de " + String.Join(' ', nbs) + " est : " + sum / nbs.Length);
        }
    }
}
