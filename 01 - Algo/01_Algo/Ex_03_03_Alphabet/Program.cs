namespace Ex_03_03_Alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userInput;
            String trimmedUI;
            char lettre;

            int[] alphabet = new int[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = 0;
            }
            int currLetter;

            do
            {
                Console.WriteLine("Saisir un texte d'au moins 120 lettres\n");
                userInput = (Console.ReadLine()).Trim();
                trimmedUI = userInput.Replace(" ", "");
                trimmedUI = trimmedUI.Replace(".", "");
                trimmedUI = trimmedUI.Replace(",", "");
                trimmedUI = trimmedUI.Replace("'", "");
                if (trimmedUI.Length < 120)
                {
                    Console.WriteLine("\nLe texte contient moins de 120 lettres\n");
                }
            }
            while (trimmedUI.Length < 120);
            foreach (char c in trimmedUI)
            {
                currLetter = Convert.ToByte(c);
                if (currLetter <= 90)
                {
                    alphabet[currLetter - 65]++;
                }
                else
                {
                    alphabet[currLetter - 97]++;
                }
            }
            Console.WriteLine("\nNombre d'occurence de chacunes des lettres : \n");
            for (int i = 0; i < alphabet.Length; i++)
            {
                lettre = Convert.ToChar(i + 65);
                Console.WriteLine(lettre + " : " + alphabet[i]);
            }
        }
    }
}
