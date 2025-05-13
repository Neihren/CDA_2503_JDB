namespace Ex_01_08_Bissextile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.Write("Veuillez saisir une année : ");
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Cette année est bissextile");
            }
            else
            {
                Console.WriteLine("Cette année n'est pas bissextile");
            }
        }
    }
}
