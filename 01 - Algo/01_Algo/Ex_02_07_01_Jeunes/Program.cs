namespace Ex_02_07_01_Jeunes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string[] agesArray;
            int younglingAmount;
            int currAge;

            younglingAmount = 0;
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
            }
            Console.WriteLine("Il y a " + younglingAmount + " jeunes");
        }
    }
}
