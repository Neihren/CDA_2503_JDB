namespace Ex_02_02_02_FCMinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unit;
            string minInput;
            string maxInput;
            double min;
            double max;
            double result;
            
            Console.WriteLine("Saisir une unité de mesure (C ou F)");
            unit = Console.ReadLine();
            Console.WriteLine("\nSaisir la valeur minimum :");
            min = double.Parse(Console.ReadLine());
            Console.WriteLine("\nSaisir la valeur maximum (doit être supérieure à la valeur minimum");
            max = double.Parse(Console.ReadLine());
            Console.WriteLine("\nRésultat :");
            while (min <= max)
            {
                if (unit.Equals("C"))
                {
                    result = (min * 9 / 5d) + 32;
                    Console.WriteLine(min + " °C = " + result + " °F");
                    min++;
                }
                else
                {
                    result = (min - 32) * 5 / 9d;
                    Console.WriteLine(min + " °F = " + result + " °C");
                    min++;
                }
            }
        }
    }
}
