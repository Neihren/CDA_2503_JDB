namespace Ex_01_06_NombrePremier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb;
            bool isPrime;

            isPrime = false;
            Console.Write("Veuillez saisir un nombre : ");
            nb = int.Parse(Console.ReadLine());

            if (nb > 1)
            {
                isPrime = true;
                for (int i = nb - 1; i > 1; i--)
                {
                    if (nb % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Ce nombre est premier");
            }
            else
            {
                Console.WriteLine("Ce nombre n'est pas premier");
            }
        }
    }
}
