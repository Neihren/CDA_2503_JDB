using System.Reflection.Metadata;
using CL_EditeurTexte;

class Program
{
    static void Main()
    {
        CL_EditeurTexte.Document doc = new();
        EditeurTexte editeur = new();

        Console.WriteLine("--- DÉBUT DE LA RÉDACTION ---");

        // 1. Taper du texte
        editeur.Executer(new InsererTexteCommand(doc, 0, "Bonjour"));
        Console.WriteLine($"[Doc] : '{doc.AfficherTexte()}'");

        editeur.Executer(new InsererTexteCommand(doc, 7, " le monde !"));
        Console.WriteLine($"[Doc] : '{doc.AfficherTexte()}'");

        // 2. On fait une faute de frappe, on efface "monde"
        editeur.Executer(new SupprimerTexteCommand(doc, 11, 5));
        Console.WriteLine($"[Doc] après suppression : '{doc.AfficherTexte()}'");

        // 3. On remplace par "chat"
        editeur.Executer(new InsererTexteCommand(doc, 11, "chat"));
        Console.WriteLine($"[Doc] après insertion : '{doc.AfficherTexte()}'");

        Console.WriteLine("\n--- UTILISATION DU CTRL+Z (ANNULER) ---");

        editeur.Annuler(); // Annule "chat"
        Console.WriteLine($"[Ctrl+Z] 1 : '{doc.AfficherTexte()}'");

        editeur.Annuler(); // Annule la suppression de "monde" (le texte réapparaît !)
        Console.WriteLine($"[Ctrl+Z] 2 : '{doc.AfficherTexte()}'");

        Console.WriteLine("\n--- UTILISATION DU CTRL+Y (REFAIRE) ---");

        editeur.Refaire(); // Refait la suppression de "monde"
        Console.WriteLine($"[Ctrl+Y] 1 : '{doc.AfficherTexte()}'");
    }
}