using System.Runtime.CompilerServices;

namespace Ex_03_06_Pendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToFind;
            int playerLifes;
            string playedLetters;
            string currentLetter;
            bool validLetter;
            bool letterFound;
            string cluesDisplay;


            playerLifes = 6;
            playedLetters = "";
            wordToFind = "";
            currentLetter = "";
            validLetter = true;
            letterFound = false;
            cluesDisplay = "";

            do
            {
                Console.WriteLine("Premier joueur, proposer un mot de minimum 5 lettres.");
                wordToFind = Console.ReadLine();
                wordToFind = wordToFind.ToUpper();
            }
            while (wordToFind.Length < 5);


            char[] wordLetters = wordToFind.ToCharArray();
            char[] clues = wordToFind.ToCharArray();
            for (int i = 1; i < clues.Length - 1; i++)
            {
                clues[i] = '-';
            }
            do
            {
                Console.Clear();
                Console.WriteLine("Nombres de vie : " + playerLifes);
                Console.WriteLine("Lettres déjà jouées : " + playedLetters + "\n");
                cluesDisplay = new string(clues);
                Console.WriteLine("Mot à deviner " + cluesDisplay + "\n");
                do
                {
                    Console.WriteLine("Proposer une lettre : ");
                    currentLetter = Console.ReadLine();
                    currentLetter = currentLetter.ToUpper();
                    if (playedLetters.Contains(currentLetter, System.StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("\nCette lettre à déjà été jouée");
                        validLetter = false;
                    }
                    else
                    {
                        playedLetters += currentLetter;
                        validLetter = true;
                    }
                }
                while (!validLetter);
                for (int i = 1; i < clues.Length - 1; i++)
                {
                    if (wordLetters[i].Equals(char.Parse(currentLetter)))
                    {
                        clues[i] = char.Parse(currentLetter);
                        letterFound = true;
                    }
                }
                if (!letterFound)
                {
                    playerLifes--;
                }
                else if (wordToFind.Equals(new string(clues)))
                {
                    Console.Clear();
                    Console.WriteLine("Nombres de vie : " + playerLifes);
                    Console.WriteLine("Lettres déjà jouées : " + playedLetters + "\n");
                    cluesDisplay = new string(clues);
                    Console.WriteLine("Mot à deviner " + cluesDisplay + "\n");
                    Console.WriteLine("Vous avez gagné");
                    return;
                }
                letterFound = false;
            }
            while (playerLifes > 0);
            Console.WriteLine("Vous avez perdu, le mot a trouver était : " + wordToFind);
        }

    }
}
