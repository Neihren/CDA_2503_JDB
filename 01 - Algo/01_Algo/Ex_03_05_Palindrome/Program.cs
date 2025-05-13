internal class Program
{
    private static void Main(string[] args)
    {
        string userInput;
        string trimmedInput;


        Console.WriteLine("Saisir une chaine de caractères pour savoir si c'est un Palindrome (terminer la chaine avec un \".\")");
        userInput = Console.ReadLine();
        trimmedInput = userInput.Replace(" ", "");
        trimmedInput = trimmedInput.Replace(",", "");
        trimmedInput = trimmedInput.Replace("-", "");
        trimmedInput = trimmedInput.Replace("'", "");
        trimmedInput = trimmedInput.Replace(".", "");

        char[] charA = trimmedInput.ToCharArray();
        Array.Reverse(charA);
        string reversed = new string(charA);
        if (reversed.Equals(trimmedInput))
        {
            Console.WriteLine("C'est un palindrome");
        }
        else
        {
            Console.WriteLine("Ce n'est pas un palindrome");
        }
        Console.WriteLine(reversed);
        Console.WriteLine(trimmedInput);
    }
}