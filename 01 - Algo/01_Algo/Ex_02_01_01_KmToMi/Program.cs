namespace Ex_02_01_01_KmToMi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double value;
            double result;

            do
            {
                Console.WriteLine("Saisir une valeur en kilomètre comprise entre 0,01 et 1000000 : ");
                userInput = Console.ReadLine();
                if (userInput.Equals("q"))
                {
                    Environment.Exit(0);
                }
                value = double.Parse(userInput);
            } while (value <= 0.01 || value >= 1000000);

            result = value / 1.609;
            Console.WriteLine(value + " Kilomètres = " + result + " Miles");
        }
    }
}