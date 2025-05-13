namespace Ex_01_07_Tri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string[] nbs;
            List<int> numbers = new List<int>();

            Console.WriteLine("Veuillez saisir des nombres séparés par des espaces :");
            userInput = Console.ReadLine();
            nbs = userInput.Split(' ');
            for (int i = 0; i < nbs.Length; i++) {
                numbers.Add(int.Parse(nbs[i]));
            }
            numbers.Sort();
            Console.WriteLine("Les nombres triées sont :");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
