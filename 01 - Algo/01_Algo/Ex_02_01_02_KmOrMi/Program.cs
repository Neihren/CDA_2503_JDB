namespace Ex_02_01_02_KmOrMi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string[] nb;
            double value;
            double result;

            Console.WriteLine("Saisir une valeur et son unité de mesure (km ou mi, séparés par un espace)");
            userInput = Console.ReadLine();
            nb = userInput.Split(' ');
            value = double.Parse(nb[0]);
            if (userInput.Contains("mi"))
            {
                result = value * 1.609;
                Console.WriteLine(value + " Miles = " + result + " Kilomètres");
            }
            else
            {
                result = value / 1.609;
                Console.WriteLine(value + " Kilomètres = " + result + " Miles");
            }
        }
    }
}