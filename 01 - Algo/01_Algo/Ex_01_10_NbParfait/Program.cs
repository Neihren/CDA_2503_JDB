namespace Ex_01_10_NbParfait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum;
            int neededAmount;
            int amount;
            List<int> dividers = new List<int>();
            List<int> perfectsNumbers = new List<int>();

            amount = 0;
            sum = 0;
            number = 2;
            Console.Write("Veuillez saisir le nombre de nombre parfaits voulus : ");
            neededAmount = int.Parse(Console.ReadLine());
            while (amount < neededAmount)
            {
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        dividers.Add(i);
                    }
                }
                foreach (int i in dividers)
                {
                    sum += i;
                }

                if (sum == number)
                {
                    perfectsNumbers.Add(number);
                    amount++;
                }
                sum = 0;
                number++;
                dividers.Clear();
            }
            Console.Write("Les " + neededAmount + " premiers nombre parfaits sont : ");
            foreach (int i in perfectsNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
