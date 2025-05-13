namespace Ex_02_01_03_KmMiGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            List<string> inputs = new List<string>();

            userInput = "";

            do
            {
                Console.WriteLine("Saisir une valeur à convertir et son unité de mesure (séparés par un espace) ou go");
                userInput = Console.ReadLine();
                inputs.Add(userInput);
            }
            while (!userInput.Equals("go"));
            inputs.Remove("go");
            foreach (string input in inputs)
            {
                double result;
                double value;
                string[] nb;

                nb = input.Split(' ');
                value = double.Parse(nb[0]);
                if (input.Contains("mi"))
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
}
