namespace Ex_03_04_TriTableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 9999);
            }

            Console.WriteLine("La liste de nombres initiale :");
            WriteTab(numbers);
            
            SortTab(ref numbers);
            
            Console.WriteLine("\n\nLa liste de nombres triée :");
            WriteTab(numbers);

        }

        public static void SortTab (ref int[] _tab)
        {
            int lowest;
            int lowestIndex;

            lowestIndex = 0;
            lowest = 0;
            for (int i = 0; i < _tab.Length; i++)
            {
                lowest = _tab[i];
                for (int j = i; j < _tab.Length; j++)
                {
                    if (_tab[j] <= lowest)
                    {
                        lowestIndex = j;
                    }
                }
                lowest = _tab[lowestIndex];
                _tab[lowestIndex] = _tab[i];
                _tab[i] = lowest;
            }
        }

        public static void WriteTab(int[] _tab)
        {
            foreach (int i in _tab)
            {
                Console.Write(i + " ");
            }
        }
    }
}