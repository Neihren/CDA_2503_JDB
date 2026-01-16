namespace CL_Loan
{
    public class Loan
    {
        private string name;
        private int amount;
        private int length;
        private int rate;
        private int frequency;

        public Loan(string name, int amount, int length, int rate, int frequency)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                this.name = "";
            }
            else
            {
                this.name = name;
            }
            this.amount = amount;
            this.length = length;
            this.rate = rate;
            this.frequency = frequency;
        }

        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Length { get => length; set => length = value; }
        public int Rate { get => rate; set => rate = value; }
        public int Frequency { get => frequency; set => frequency = value; }
    }
}
