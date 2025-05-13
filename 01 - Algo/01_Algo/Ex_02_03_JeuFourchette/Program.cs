namespace Ex_02_03_JeuFourchette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cpuNumber;
            int playerNumber;
            int lowerLimit;
            int upperLimit;
            
            Random rnd = new Random();
            cpuNumber = rnd.Next(0, 101);
            lowerLimit = 0;
            upperLimit = 100;
            do
            {
                Console.WriteLine("Choisir un nombre entre " + lowerLimit + " et " + upperLimit + " (compris) : ");
                playerNumber = int.Parse(Console.ReadLine());
                if (playerNumber < cpuNumber && playerNumber > lowerLimit)
                {
                   lowerLimit = playerNumber;
                }
                else if (playerNumber > cpuNumber && playerNumber < upperLimit)
                {
                    upperLimit = playerNumber;
                }
            }
            while (playerNumber != cpuNumber);
            Console.WriteLine("Le nombre a deviner était " + cpuNumber + ", Bravo !");
        }
    }
}
