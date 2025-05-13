namespace Ex_01_05_CalculInterets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount;
            double rate;
            int year;
            double simpleInterest;
            double composedInterest;

            Console.Write("Saisir une somme initiale : ");
            amount = double.Parse(Console.ReadLine());
            Console.Write("Saisir un taux d'intérêt : ");
            rate = double.Parse(Console.ReadLine());
            Console.Write("Saisir la durée du placement en années : ");
            year = int.Parse(Console.ReadLine());
            simpleInterest = amount * (1 + year * rate);
            composedInterest = amount * Math.Pow((1 + rate), year);
            Console.WriteLine("\nIntérêt simple = " + simpleInterest);
            Console.WriteLine("Intérêt composé = " + composedInterest);
        }
    }
}
