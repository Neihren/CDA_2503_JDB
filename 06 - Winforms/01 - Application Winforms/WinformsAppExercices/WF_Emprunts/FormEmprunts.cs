using System.Globalization;
using CL_Loan;

namespace WF_Emprunts
{
    public partial class FormEmprunts : Form
    {
        Loan curLoan;
        private const Double Rate7 = 0.07;
        private const Double Rate8 = 0.08;
        private const Double Rate9 = 0.09;

        public FormEmprunts()
        {
            InitializeComponent();
            listBox_Periode.Items.Add("Mensuelle");
            listBox_Periode.Items.Add("Bimestrielle");
            listBox_Periode.Items.Add("Trimestrielle");
            listBox_Periode.Items.Add("Semestrielle");
            listBox_Periode.Items.Add("Annuelle");
            radioButton_7.CheckedChanged += new EventHandler(RadioButtons_CheckedChanged);
            radioButton_8.CheckedChanged += new EventHandler(RadioButtons_CheckedChanged);
            radioButton_9.CheckedChanged += new EventHandler(RadioButtons_CheckedChanged);
            curLoan = new Loan();
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
                hScrollBar_Duree.SmallChange = 1;
                hScrollBar_Duree.LargeChange = 1;
                hScrollBar_Duree.Maximum = 300;
            }
            else if (frequency == 1)
            {
                hScrollBar_Duree.SmallChange = 2;
                hScrollBar_Duree.LargeChange = 2;
                hScrollBar_Duree.Maximum = 301;
            }
            else if (frequency == 2)
            {
                hScrollBar_Duree.SmallChange = 3;
                hScrollBar_Duree.LargeChange = 3;
                hScrollBar_Duree.Maximum = 302;
            }
            else if (frequency == 3)
            {
                hScrollBar_Duree.SmallChange = 6;
                hScrollBar_Duree.LargeChange = 6;
                hScrollBar_Duree.Maximum = 305;
            }
            else if (frequency == 4)
            {
                hScrollBar_Duree.SmallChange = 12;
                hScrollBar_Duree.LargeChange = 12;
                hScrollBar_Duree.Maximum = 311;
            }
        }

        private void CalculateAndDisplay()
        {
            label_Amount.Text = curLoan.CalcRemb().ToString("C", CultureInfo.CurrentCulture);
            label_NbRemboursements.Text = (curLoan.Length / curLoan.Frequency).ToString();
        }


        private void HScrollBar_Duree_ValueChanged(object sender, EventArgs e)
        {
            //if (hScrollBar_Duree.Value < 2 && listBox_Periode.SelectedIndex == 1)
            //{
            //    errorProviderHsError.SetError(hScrollBar_Duree, "Pour une périodicité Bimestrielle, la durée du remboursement ne peut pas être inférieur à 2");
            //}
            //else if (hScrollBar_Duree.Value < 3 && listBox_Periode.SelectedIndex == 2)
            //{
            //    errorProviderHsError.SetError(hScrollBar_Duree, "Pour une périodicité Trimestrielle, la durée du remboursement ne peut pas être inférieur à 3");
            //}
            //else if (hScrollBar_Duree.Value < 6 && listBox_Periode.SelectedIndex == 3)
            //{
            //    errorProviderHsError.SetError(hScrollBar_Duree, "Pour une périodicité Semestrielle, la durée du remboursement ne peut pas être inférieur à 6");
            //}
            //else if (hScrollBar_Duree.Value < 12 && listBox_Periode.SelectedIndex == 4)
            //{
            //    errorProviderHsError.SetError(hScrollBar_Duree, "Pour une périodicité Annuelle, la durée du remboursement ne peut pas être inférieur à 12");
            //}
            //else
            //{
                errorProviderHsError.Clear();
                label_NbDuree.Text = hScrollBar_Duree.Value.ToString();
                curLoan.Length = hScrollBar_Duree.Value;
                CalculateAndDisplay();
            //}



        }

        private void ListBox_Periode_SelectedIndexChanged(object sender, EventArgs e)
        {
            HScollBarSetup(listBox_Periode.SelectedIndex);
            curLoan.Frequency = hScrollBar_Duree.SmallChange;
            CalculateAndDisplay();
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                if (((RadioButton)sender) == radioButton_7)
                {
                    curLoan.Rate = Rate7;
                }
                else if (((RadioButton)sender) == radioButton_8)
                {
                    curLoan.Rate = Rate8;
                }
                else if (((RadioButton)sender) == radioButton_9)
                {
                    curLoan.Rate = Rate9;
                }
                CalculateAndDisplay();
            }
        }

        private void TextBox_Capital_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Capital.Text))
            {
                curLoan.Amount = 0;
            }
            else
            {
                curLoan.Amount = int.Parse(textBox_Capital.Text);
            }
            CalculateAndDisplay();
        }

        private void HScrollBar_Duree_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue > 1 && e.OldValue >=  2 && e.NewValue % 2 != 0)
            {
                e.NewValue = e.NewValue - 1;
            }
        }
    }
}
