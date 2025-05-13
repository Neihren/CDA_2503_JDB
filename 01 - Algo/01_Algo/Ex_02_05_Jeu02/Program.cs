namespace Ex_02_05_Jeu02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerNumber;
            int cpuNumber;
            int playerScore;
            int cpuScore;

            playerScore = 0;
            cpuScore = 0;
            Random rnd = new Random();
            do
            {
                Console.WriteLine("\nPour arrêter la partie saisir un chiffre négatif\n");

                Console.WriteLine("\nScore joueur : " + playerScore);
                Console.WriteLine("Score ordinateur : " + cpuScore);

                Console.Write("Entrer l'une de ces valeurs : 0, 1 ou 2 : ");
                playerNumber = int.Parse(Console.ReadLine());
                cpuNumber = rnd.Next(0, 3);
                Console.WriteLine("L'ordinateur à choisi : " + cpuNumber);
                if ((playerNumber - cpuNumber) == 2 || (playerNumber - cpuNumber) == -1)
                {
                    playerScore++;
                }
                else if ((playerNumber - cpuNumber) == -2 || (playerNumber - cpuNumber) == 1)
                {
                    cpuScore++;
                }
                
            }
            while (playerScore < 10 && cpuScore < 10 && playerNumber >= 0);
        }
    }
}
