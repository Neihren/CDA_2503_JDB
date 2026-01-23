namespace CL_Loan
{
    public class Loan
    {
        private string name;
        private int amount;
        private int length;
        private double rate;
        private int frequency;

        public Loan()
        {
            this.name = "";
            this.amount = 0;
            this.length = 1;
            this.rate = 0.07d;
            this.frequency = 1;
        }
        
        public Loan(string name, int amount, int length, float rate, int frequency)
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
        public double Rate { get => rate; set => rate = value; }
        public int Frequency { get => frequency; set => frequency = value; }

        public double CalcRemb()
        {
            if (this.amount > 0)
            {
                double monthlyRate = this.rate / 12;
                double remb = this.amount * (monthlyRate / (1 - Math.Pow(1 + monthlyRate, -this.length)));
                remb *= this.frequency;
                return remb;
            }
            return 0;
        }
    }
}
