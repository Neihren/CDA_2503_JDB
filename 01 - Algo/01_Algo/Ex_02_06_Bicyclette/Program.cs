using System.Runtime.CompilerServices;

namespace Ex_02_06_Bicyclette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool faitBeau;
            bool bicycletteOk;
            bool quickRepair;
            bool bookFound;
            bool bookAvailable;
            string userInput;

            faitBeau = false;
            bicycletteOk = false;
            quickRepair = false;
            bookFound = false;
            bookAvailable = false;

            Console.Write("Est ce qu'il fait beau (O/N) ? ");
            userInput = Console.ReadLine();
            if (userInput == "O")
            {
                faitBeau = true;
            }
            if (faitBeau)
            {
                Console.Write("Est ce que la bicyclette est en état (O/N) ? ");
                userInput = Console.ReadLine();
                if (userInput == "O")
                {
                    bicycletteOk = true;
                }
                else
                {
                    Console.Write("Les réparations sont-elles immédiates (O/N) ? ");
                    userInput = Console.ReadLine();
                    if (userInput == "O")
                    {
                        quickRepair = true;
                    }
                }
                if (bicycletteOk || quickRepair)
                {
                    Console.WriteLine("Balade en vélo");
                }
                else
                {
                    Console.WriteLine("Cueillette de joncs au lac");
                }
            }
            else
            {
                Console.Write("Est ce que vous avez votre livre (O/N) ? ");
                userInput = Console.ReadLine();
                if (userInput == "O")
                {
                    bookFound = true;
                }
                else
                {
                    Console.Write("Le livre est-il disponible à la bibliothèque (O/N) ? ");
                    userInput = Console.ReadLine();
                    if (userInput == "O")
                    {
                        bookAvailable = true;
                    }
                }
                if (bookFound || bookAvailable)
                {
                    Console.WriteLine("Lecture de Game of Thrones T1 dans le fauteuil");
                }
                else
                {
                    Console.WriteLine("Lecture d'un roman policier dans le fauteuil");
                }
            }
        }
    }
}
