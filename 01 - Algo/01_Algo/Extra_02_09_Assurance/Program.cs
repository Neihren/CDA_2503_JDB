namespace Extra_02_09_Assurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir l'age du conducteur : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le nombre d'années de permis du conducteur : ");
            int permit = int.Parse(Console.ReadLine());
            Console.WriteLine("De combien d'accidents le conducteur a été responsable ? ");
            int accident = int.Parse(Console.ReadLine());
            Console.WriteLine("Depuis combien d'année le conducteur est il assuré ? ");
            int years = int.Parse(Console.ReadLine());
            int insurance = 3;
            string[] color = { "refusée.", "rouge.", "orange.", "vert.", "bleu." };
            if (age < 25)
                insurance -= 1;
            if (permit < 2)
                insurance -= 1;
            while (accident > 0)
            {
                insurance -= 1;
                accident--;
            }
            if (insurance > 0 && years >= 5)
                insurance++;
            if (insurance < 0)
                insurance = 0;
            if (insurance > 0)
                Console.WriteLine("La demande d'assurance est acceptée et le tarif est " + color[insurance]);
            else
                Console.WriteLine("La demande d'assurance est " + color[insurance]);
        }
    }
}
