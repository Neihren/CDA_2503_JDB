namespace Extra_02_08_Elections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez saisir le nombre de voix du 1er candidat : ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Veuillez saisir le nombre de voix du 2nd candidat : ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Veuillez saisir le nombre de voix du 3e candidat : ");
            int third = int.Parse(Console.ReadLine());
            Console.Write("Veuillez saisir le nombre de voix du 4e candidat : ");
            int fourth = int.Parse(Console.ReadLine());
            double sum = first + second + third + fourth;
            if (first > sum / 2)
                Console.WriteLine("Le 1er candidat est élu au premier tour");
            else if (first <= sum / 8 || second > sum / 2 || third > sum / 2 || fourth > sum / 2)
                Console.WriteLine("Le 1er candidat est battu");
            else if (first > second && first > third && first > fourth)
                Console.WriteLine("Le 1er candidat est en ballottage favorable");
            else
                Console.WriteLine("Le 1er candidat est en ballottage défaborable");
        }
    }
}
