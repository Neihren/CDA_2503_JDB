using System.Runtime.CompilerServices;

namespace Extra_02_07_ValiditeDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir une année : ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir un mois : ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir un jour : ");
            int day = int.Parse(Console.ReadLine());
            if (month > 12 || (((year % 4 == 0 && year % 100 != 0 || year % 400 == 0) && month == 2 && day > 29))
                                || (!(year % 4 == 0 && year % 100 != 0 || year % 400 == 0) && month == 2 && day > 28)
                                || (((month < 8 && month % 2 != 0)
                                    || (month > 7 && month % 2 == 0))
                                    && day > 31)
                                || (((month < 8 && month % 2 == 0)
                                    || (month > 7 && month % 2 != 0))
                                    && day > 30))
                Console.WriteLine("La date entrée est invalide");
        else
                Console.WriteLine("La date entrée est valide");
        }
    }
}
