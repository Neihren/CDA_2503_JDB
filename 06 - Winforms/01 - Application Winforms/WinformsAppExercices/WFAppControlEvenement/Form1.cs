using WFControlDisBonjour;

namespace WFAppControlEvenement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uC_DisBonjourTest_NomIdentified(object sender, EventArgs e)
        {
            UC_DisBonjour? nom = sender as UC_DisBonjour;
            if (nom != null)
            {
                MessageBox.Show("Salut " + nom.NomDestinataire);
            }
        }

        private void uC_DisBonjour2_NomIdentified(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
