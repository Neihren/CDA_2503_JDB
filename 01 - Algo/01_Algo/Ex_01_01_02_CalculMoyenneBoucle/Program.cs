namespace Ex_01_01_02_CalculMoyenneBoucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String redo = "O";
            do
            {
                Console.WriteLine("Programme de calcul de la moyenne de 2 nombres.");
                Console.WriteLine("Veuillez saisir 2 nombres séparés par un espace :");
                String userInput = Console.ReadLine();
                String[] nbs = userInput.Split(' ');
                Console.WriteLine("La moyenne de " + nbs[0] + " et " + nbs[1] + " est : " + (int.Parse(nbs[0]) + int.Parse(nbs[1])) / 2.0);
                Console.WriteLine("Souhaitez-vous faire un autre calcul ? (O/N)");
                redo = Console.ReadLine();
            }
            while (redo == "O");
        }
    }
}
