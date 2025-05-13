namespace Ex_02_02_FC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string[] input;
            double value;
            double result;

            do
            {
                Console.WriteLine("Saisir une valeur comprise entre -459,67 et 5000000\nsuivi d'une unité de température (C ou F) séparé par un espace");
                userInput = Console.ReadLine();
                input = userInput.Split(' ');
                value = double.Parse(input[0]);
                Console.WriteLine();
            }
            while (value < -459.67 || value > 5000000);


            if (userInput.Contains("C"))
            {
                result = (value * 9 / 5d) + 32;
                Console.WriteLine(value + " °C = " + result + " °F");
                
            }
            else
            {
                result = (value - 32) * 5 / 9d;
                Console.WriteLine(value + " °F = " + result + " °C");
            }
        }
    }
}
