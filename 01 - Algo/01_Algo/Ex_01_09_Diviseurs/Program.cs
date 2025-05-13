namespace Ex_01_09_Diviseurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            List<int> dividers = new List<int>();
            
            Console.Write("Veuillez saisir un nombre entier : ");
            number = int.Parse(Console.ReadLine());
            for (int i = number - 1; i > 1; i--)
            {
                if (number % i == 0)
                {
                    dividers.Add(i);
                }
            }
            Console.WriteLine("Les diviseurs de " + number + " sont : ");
            foreach (int i in dividers)
            {
                Console.Write(i + " ");
            }
        }
    }
}
