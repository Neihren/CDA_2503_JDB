namespace Extra_Majorite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateInput;
            DateTime today = DateTime.Today;
            int age;

            Console.Write("Saisir votre date de naissance (JJ/MM/AAAA) : ");
            dateInput = Console.ReadLine();
            DateTime dob = DateTime.Parse(dateInput);
            
            age = today.Year - dob.Year;
            if (dob > today.AddYears(-age))
            {
                age--;
            }
            if (age >= 18)
            {
                Console.WriteLine("Vous etes majeur ({0} ans)", age);
            }
            else
            {
                Console.WriteLine("Vous etes mineur ({0} ans)", age);
            }
        }
    }
}
