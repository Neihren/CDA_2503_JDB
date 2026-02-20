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
        private static int compteur = 0;

        private readonly int[] frequencySteps = { 1, 2, 3, 6, 12 };

        public FormEmprunts()
        {
            InitializeComponent();
            compteur++;
            this.Text = "Emprunts N°" + compteur;
            listBox_Periode.Items.AddRange(new object[] {
                "Mensuelle",
                "Bimestrielle",
                "Trimestrielle",
                "Semestrielle",
                "Annuelle"
            });
            curLoan = new Loan();
            Reset();
        }

        /// <summary>
        /// Fonction pour remettre tous les elements de l'IHM par défaut
        /// </summary>
        private void Reset()
        {
            textBox_Nom.Focus();
            radioButton_7.Checked = true;
            curLoan.Rate = Rate7;
            listBox_Periode.SelectedIndex = 0;
            textBox_Capital.Clear();
            label_NbDuree.Text = "1";
        }

        /// <summary>
        /// Ajuste la valeur de la scrollbar pour qu'elle corresponde à un multiple de la périodicité choisie.
        /// </summary>
        /// <param name="currentValue">La valeur actuelle de la scrollbar avant correction.</param>
        /// <param name="step">Le pas (incrément) correspondant à la périodicité.</param>
        /// <returns>Le multiple de la périodicité immédiatement inférieur ou égal à la valeur initiale.</returns>
        private int SnapScrollBarValue(int currentValue, int step)
        {
            if (currentValue % step != 0)
            {
                return (currentValue / step) * step;
            }
            return currentValue;
        }

        /// <summary>
        /// Configure les bornes (Minimum, Maximum) et le pas (LargeChange/SmallChange) de la barre de défilement
        /// en fonction de la périodicité sélectionnée par l'utilisateur.
        /// </summary>
        /// <param name="frequencyIndex">
        /// L'index de la périodicité sélectionnée dans la ListBox (0 pour Mensuelle, 1 pour Bimestrielle, etc.),
        /// utilisé pour récupérer le pas correspondant dans le tableau frequencySteps.
        /// </param>
        /// <remarks>
        /// Le Maximum est calculé dynamiquement (299 + step) pour garantir une amplitude de choix constante 
        /// quelle que soit la périodicité.
        /// </remarks>
        private void HScollBarSetup(int frequencyIndex)
        {
            if (frequencyIndex < 0 || frequencyIndex >= frequencySteps.Length)
            {
                return;
            }
            int step = frequencySteps[frequencyIndex];
            if (hScrollBar_Duree.Value < step)
            {
                hScrollBar_Duree.Value = step;
            }
            hScrollBar_Duree.Minimum = step;
            hScrollBar_Duree.SmallChange = step;
            hScrollBar_Duree.LargeChange = step;
            hScrollBar_Duree.Maximum = 299 + step;
        }

        /// <summary>
        /// Déclenche les calculs de l'emprunt via l'objet métier et met à jour l'affichage des résultats.
        /// </summary>
        /// <remarks>
        /// Cette méthode vérifie d'abord si un capital (Amount) est défini dans l'objet Loan :
        ///     Si oui : elle calcule le montant du remboursement (formaté en devise locale) et le nombre d'échéances.
        ///     Si non (montant à 0) : elle vide les étiquettes pour garder l'interface propre.
        /// </remarks>
        private void CalculateAndDisplay()
        {
            if (curLoan.Amount > 0)
            {
                label_Amount.Text = curLoan.CalcRemb().ToString("C", CultureInfo.CurrentCulture);
                label_NbRemboursements.Text = curLoan.NbRemb().ToString();
            }
            else
            {
                label_Amount.Text = "0,00 €";
                label_NbRemboursements.Text = "0";
            }
        }


        private void HScrollBar_Duree_ValueChanged(object sender, EventArgs e)
        {
            label_NbDuree.Text = hScrollBar_Duree.Value.ToString();
            curLoan.Length = hScrollBar_Duree.Value;
            CalculateAndDisplay();
        }

        private void HScrollBar_Duree_Scroll(object sender, ScrollEventArgs e)
        {
            int currentStep = frequencySteps[listBox_Periode.SelectedIndex];
            e.NewValue = SnapScrollBarValue(e.NewValue, currentStep);
        }

        private void ListBox_Periode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox_Periode.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            HScollBarSetup(index);
            int currentStep = frequencySteps[index];
            curLoan.Frequency = currentStep;
            hScrollBar_Duree.Value = SnapScrollBarValue(hScrollBar_Duree.Value, currentStep);
            CalculateAndDisplay();
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                if (rb == radioButton_7) curLoan.Rate = Rate7;
                else if (rb == radioButton_8) curLoan.Rate = Rate8;
                else if (rb == radioButton_9) curLoan.Rate = Rate9;
                CalculateAndDisplay();
            }
        }

        private void TextBox_Capital_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Capital.Text))
            {
                curLoan.Amount = 0;
                errorProviderAmount.Clear();
            }
            else if (int.TryParse(textBox_Capital.Text, out int val))
            {
                curLoan.Amount = val;
                errorProviderAmount.Clear();
            }
            else
            {
                errorProviderAmount.SetError(textBox_Capital, "Saisir un entier valide uniquement.");
            }
            CalculateAndDisplay();
        }
    }
}
