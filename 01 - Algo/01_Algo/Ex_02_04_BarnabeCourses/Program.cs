namespace Ex_02_04_BarnabeCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double thunass;
            int nbMag;

            nbMag = 0;
            Console.WriteLine("Entrée la somme dont disposait Barnabé au départ ( > 1 euro)");
            thunass = double.Parse(Console.ReadLine());
            while (thunass > 2)
            {
                thunass = (thunass / 2) - 1;
                nbMag++;
            }
            nbMag += 1;
            Console.WriteLine("Barnabé a fait des achats dans " + nbMag + " magasins.");
        }
    }
}
