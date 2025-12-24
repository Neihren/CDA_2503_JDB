using _01_CL_RegleDeControle;

internal class Program
{
    
    static void Main()
    {
        // Validation Nom
        string nameInput = "Dupont";
        bool nameInputValid = false;
        nameInputValid = BoiteAOutilDeRegles.IsNameNotAlphabetic(nameInput);
        Console.WriteLine($"Nom : {nameInput}");
        Console.WriteLine(nameInputValid);
        Console.WriteLine(nameInput);
        Console.WriteLine();
        // Validation Nom = caratères spéciaux
        nameInput = "François L'Écuyer";
        nameInputValid = false;
        nameInputValid = BoiteAOutilDeRegles.IsNameNotAlphabetic(nameInput);
        Console.WriteLine($"Nom : {nameInput}");
        Console.WriteLine(nameInputValid);
        Console.WriteLine(nameInput);
        Console.WriteLine();
        // Validation Nom = vide
        nameInput = "";
        nameInputValid = false;
        nameInputValid = BoiteAOutilDeRegles.IsEmpty(nameInput);
        Console.WriteLine($"Nom : {nameInput}");
        Console.WriteLine(nameInputValid);
        Console.WriteLine(nameInput);
        Console.WriteLine();
        // Validation Nom = Tiret
        nameInput = "Jean-Martin";
        nameInputValid = false;
        nameInputValid = BoiteAOutilDeRegles.IsNameNotAlphabetic(nameInput);
        Console.WriteLine($"Nom : {nameInput}");
        Console.WriteLine(nameInputValid);
        Console.WriteLine(nameInput);
        Console.WriteLine();
        // Validation Nom = chiffre
        nameInput = "Jean-Mart1";
        nameInputValid = false;
        nameInputValid = BoiteAOutilDeRegles.IsNameNotAlphabetic(nameInput);
        Console.WriteLine($"Nom : {nameInput}");
        Console.WriteLine(nameInputValid);
        Console.WriteLine(nameInput);
        Console.WriteLine();

        // Validation Nom = espace début
        nameInput = " Jean-Mart";
        nameInputValid = false;
        nameInputValid = BoiteAOutilDeRegles.IsStartingSpace(nameInput);
        Console.WriteLine($"Nom : {nameInput}");
        Console.WriteLine(nameInputValid);
        Console.WriteLine(nameInput);
        Console.WriteLine();
        // Validation Nom = espace fin
        nameInput = "Jean-Mart ";
        nameInputValid = false;
        nameInputValid = BoiteAOutilDeRegles.IsEndingSpace(nameInput);
        Console.WriteLine($"Nom : {nameInput}");
        Console.WriteLine(nameInputValid);
        Console.WriteLine(nameInput);
        Console.WriteLine();

        // Validation Date
        string dateInput = "22/12/2025";
        DateTime dateOuput = DateTime.MinValue;
        bool dateValid = false;
        dateValid = BoiteAOutilDeRegles.IsDateFormatValid(dateInput, out dateOuput);
        Console.WriteLine("Date :");
        Console.WriteLine(dateValid);
        Console.WriteLine(dateOuput);
        Console.WriteLine();

        // Validation Code Postal
        string codePostalInput = "77480";
        bool codePostalInputValid = false;

        codePostalInputValid = BoiteAOutilDeRegles.IsCodePostalValid(codePostalInput);
        Console.WriteLine("Code Postal :");
        Console.WriteLine(codePostalInput);
        Console.WriteLine(codePostalInputValid);
        Console.WriteLine();

        // Validation Montant
        string montantInput = "45157,445";
        bool montantInputValid = false;
        decimal montantOutput = decimal.MinValue;
        montantInputValid = BoiteAOutilDeRegles.IsAmountValid(montantInput, out montantOutput);

        Console.WriteLine("Montant :");
        Console.WriteLine(montantInputValid);
        Console.WriteLine(montantOutput);

    }
}