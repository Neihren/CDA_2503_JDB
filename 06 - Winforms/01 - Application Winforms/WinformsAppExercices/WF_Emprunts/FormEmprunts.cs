namespace WF_Emprunts
{
    public partial class FormEmprunts : Form
    {
        public FormEmprunts()
        {
            InitializeComponent();
            listBox_Periode.Items.Add("Mensuelle");
            listBox_Periode.Items.Add("Bimestrielle");
            listBox_Periode.Items.Add("Trimestrielle");
            listBox_Periode.Items.Add("Semestrielle");
            listBox_Periode.Items.Add("Annuelle");
            Reset();
        }

        private void Reset()
        {
            textBox_Nom.Focus();
            radioButton_7.Checked = true;
            label_NbDuree.Text = "1";
            hScrollBar_Duree.Value = 1;
            listBox_Periode.SelectedIndex = 0;
            button_Ok.Enabled = false;
            button_Annuler.Enabled = false;
            HScollBarSetup(listBox_Periode.SelectedIndex);
        }

        private void HScollBarSetup(int frequency)
        {
            if (frequency == 0)
            {
                hScrollBar_Duree.Minimum = 1;
                hScrollBar_Duree.SmallChange = 1;
                hScrollBar_Duree.LargeChange = 1;
                hScrollBar_Duree.Maximum = 300;
            }
            else if (frequency == 1) 
            {
                hScrollBar_Duree.Minimum = 2;
                hScrollBar_Duree.SmallChange = 2;
                hScrollBar_Duree.LargeChange = 2;
                hScrollBar_Duree.Maximum = 301;
            }
            else if (frequency == 2)
            {
                hScrollBar_Duree.Minimum = 3;
                hScrollBar_Duree.SmallChange = 3;
                hScrollBar_Duree.LargeChange = 3;
                hScrollBar_Duree.Maximum = 302;
            }
            else if (frequency == 3)
            {
                hScrollBar_Duree.Minimum = 6;
                hScrollBar_Duree.SmallChange = 6;
                hScrollBar_Duree.LargeChange = 6;
                hScrollBar_Duree.Maximum = 305;
            }
            else if (frequency == 4)
            {
                hScrollBar_Duree.Minimum = 12;
                hScrollBar_Duree.SmallChange = 12;
                hScrollBar_Duree.LargeChange = 12;
                hScrollBar_Duree.Maximum = 311;
            }
        }

        private void HScrollBar_Duree_ValueChanged(object sender, EventArgs e)
        {
            label_NbDuree.Text = hScrollBar_Duree.Value.ToString();
        }

        private void ListBox_Periode_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (hScrollBar_Duree.Value < 4 && hScrollBar_Duree.Value > listBox_Periode.SelectedIndex + 1
                || hScrollBar_Duree.Value < 6 && hScrollBar_Duree.Value > listBox_Periode.SelectedIndex + 3
                || hScrollBar_Duree.Value < 12 && hScrollBar_Duree.Value > listBox_Periode.SelectedIndex + 8)
            {
                errorProvider1.SetError(label_Periode, "La périodicité de remboursement ne correspond pas à la durée de remboursements");
            }
            HScollBarSetup(listBox_Periode.SelectedIndex);
        }
    }
}
