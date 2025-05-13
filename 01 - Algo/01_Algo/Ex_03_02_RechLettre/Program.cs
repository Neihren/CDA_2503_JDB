namespace Ex_03_02_RechLettre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int letterFound;
            
            char lettre = 'y';
            letterFound = 0;
            Console.WriteLine("Saisir une chaîne de caractères terminée par le caractère \".\" . ");
            userInput = Console.ReadLine();
            foreach (char searchedChar in userInput)
            {
                if(searchedChar == lettre)
                    letterFound++;
            }
            if (userInput.Equals("."))
            {
                Console.WriteLine("La phrase est vide");
            }
            else if (letterFound > 0)
            {
                Console.WriteLine("La lettre " + lettre + " apparait " + letterFound + " fois dans la phrase");
            }
            else
            {
                Console.WriteLine("La lettre n'est pas présente");
            }
        }
    }
}
