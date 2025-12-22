namespace WF_Controles
{
    public partial class Transaction : Form
    {
        private string? nom;
        private DateTime? date;
        private decimal? montant;
        private string? codePostal;

        public Transaction()
        {
            InitializeComponent();
            this.nom = null;
            this.date = null;
            this.montant = null;
            this.codePostal = null;
        }
        public Transaction(string nom, DateTime date, decimal montant, string codePostal)
        {
            InitializeComponent();
            this.nom = nom;
            this.date = date;
            this.montant = montant;
            this.codePostal = codePostal;
        }

        public string Nom { get => nom; set => nom = value; }
        public DateTime Date { get => date; set => date = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
    }
}
