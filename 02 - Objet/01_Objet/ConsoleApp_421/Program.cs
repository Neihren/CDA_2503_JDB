using ClassLibrary_421;

namespace ConsoleApp_421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            De d1 = new De();
            Console.WriteLine(d1.ToString());
            d1.ConserverDe();
            Console.WriteLine(d1.ToString());
            d1.LancerDe();
            Console.WriteLine(d1.ToString());

        }
    }
}
