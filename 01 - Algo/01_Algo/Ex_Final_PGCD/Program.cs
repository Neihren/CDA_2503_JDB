namespace Ex_Final_PGCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Saisir un premier nombre : ");
            int nb1 = int.Parse(Console.ReadLine());
            Console.Write("Saisir un deuxième nombre : ");
            int nb2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Le PGCD de " + nb1 + " et " + nb2 + " est " + PGCD(nb1,nb2));
        }

        public static int PGCD(int _n, int _m)
        {
            do
            {
                if (_n > _m)
                {
                    _n = _n - _m;
                }
                else
                {
                    _m = _m - _n;
                }
            }
            while (_m != _n);
            return _n;
        }
    }
}
