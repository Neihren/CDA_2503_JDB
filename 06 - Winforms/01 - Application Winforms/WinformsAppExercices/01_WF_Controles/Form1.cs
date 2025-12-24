using _01_CL_Achat;
using _01_CL_RegleDeControle;

namespace _01_WF_Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Fin de l'application",
                                                "FIN",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_Effacer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Vider le formulaire ?",
                                                "Effacer le formulaire",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Information,
                                                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                textBox_Nom.Clear();
                textBox_Date.Clear();
                textBox_Montant.Clear();
                textBox_CodePostal.Clear();
            }
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {

            if (BoiteAOutilDeRegles.IsEmpty(textBox_Nom.Text))
            {
                MessageBox.Show("Le nom ne peux pas être vide.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsStartingSpace(textBox_Nom.Text))
            {
                MessageBox.Show("Le nom ne peux pas commencer par un espace.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsEndingSpace(textBox_Nom.Text))
            {
                MessageBox.Show("Le nom ne peux pas terminer par un espace.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsMoreThan30(textBox_Nom.Text))
            {
                MessageBox.Show("Le nom ne doit pas depasser 30 caratères.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsNameLessThan2(textBox_Nom.Text))
            {
                MessageBox.Show("Le nom doit faire plus de 2 caractères.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsNameNotAlphabetic(textBox_Nom.Text))
            {
                MessageBox.Show("Le nom ne doit contenir que les caractères a-z, A-Z, caratères accentués, -, ',  ,.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsEmpty(textBox_Date.Text))
            {
                MessageBox.Show("La date ne peux pas être vide.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsStartingSpace(textBox_Date.Text))
            {
                MessageBox.Show("La date ne peut pas commencer par un espace.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsEndingSpace(textBox_Date.Text))
            {
                MessageBox.Show("La date ne peut pas terminer par un espace.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (!BoiteAOutilDeRegles.IsDateFormatValid(textBox_Date.Text, out DateTime dateOutput))
            {
                MessageBox.Show("La date saisie n'est pas valide.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsDateInPast(dateOutput))
            {
                MessageBox.Show("La date saisie ne doit pas être dans le passé.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsEmpty(textBox_Montant.Text))
            {
                MessageBox.Show("Le montant ne peux pas être vide.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsStartingSpace(textBox_Montant.Text))
            {
                MessageBox.Show("Le montant ne peux pas commencer par un espace.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsEndingSpace(textBox_Montant.Text))
            {
                MessageBox.Show("Le montant ne peux pas terminer par un espace.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsAmountNegative(textBox_Montant.Text))
            {
                MessageBox.Show("Le montant ne peux pas être négatif", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsAmountValid(textBox_Montant.Text, out decimal amountOutput))
            {
                MessageBox.Show("Le montant saisi n'est pas valide", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsEmpty(textBox_CodePostal.Text))
            {
                MessageBox.Show("Le Code Postal ne peux pas être vide.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsStartingSpace(textBox_CodePostal.Text))
            {
                MessageBox.Show("Le Code Postal ne peux pas commencer par un espace.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsEndingSpace(textBox_CodePostal.Text))
            {
                MessageBox.Show("Le Code Postal ne peux pas terminer par un espace.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (BoiteAOutilDeRegles.IsCodePostalValid(textBox_CodePostal.Text))
            {
                MessageBox.Show("Le Code Postal n'est pas valide. Il doit être composé de 5 chiffres", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                string info = "";
                var listeTriee = this.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex);
                Achat user1 = new Achat(textBox_Nom.Text, dateOutput, amountOutput, textBox_CodePostal.Text);
                foreach (TextBox txtbox in listeTriee)
                {
                    info += txtbox.Tag + " : " + txtbox.Text + "\n";
                }

                MessageBox.Show(info, "Validation effectuée",
                MessageBoxButtons.OK);
                
            }
        }
    }
}
