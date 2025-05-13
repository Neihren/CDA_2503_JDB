namespace Ex_02_07_02_CatAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string[] agesArray;
            int younglingAmount;
            int boomerAmount;
            int twentyAmount;
            int currAge;

            younglingAmount = 0;
            boomerAmount = 0;
            twentyAmount = 0;
            Console.WriteLine("Veuillez saisir les ages des 20 personnes séparés par des espaces");
            userInput = Console.ReadLine();
            agesArray = userInput.Split(' ');
            foreach (string age in agesArray)
            {
                currAge = int.Parse(age);
                if (currAge < 20)
                {
                    younglingAmount++;
                }
                else if (currAge > 20)
                {
                    boomerAmount++;
                }
                else
                {
                    twentyAmount++;
                }
            }
            if (younglingAmount == 20)
            {
                Console.WriteLine("TOUTES LES PERSONNES ONT MOINS DE 20 ANS");
            }
            else if (boomerAmount + twentyAmount == 20)
            {
                Console.WriteLine("TOUTES LES PERSONNES ONT PLUS DE 20 ANS");
            }
            else
            {
                Console.WriteLine("Il y a " + younglingAmount + " personnes de moins de 20 ans, " + boomerAmount + " de plus de 20 ans et " + twentyAmount + " égales à 20 ans");

            }
        }
    }
}
