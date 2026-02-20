using CL_DemandeurEmploi;
using System.ComponentModel;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WF_TrouveEmploi
{
    public partial class Form_TrouveEmploi : Form
    {
        private DemandeurEmploi demandeurValeursInitials;
        private DemandeurEmploi demandeurModifie;
        private DateOnly dateValidee;

        // Pour récupérer les nouvelles information du demandeur d'emploi
        public DemandeurEmploi DemandeurModifie { get => demandeurModifie; /*set => demandeurModifie = value;*/ }

        /// <summary>
        /// Lance et configure la fenetre en fonction des informations initiales
        /// Garde en mémoire les information initiales en cas d'annulation.
        /// </summary>
        /// <param name="demandeurAModifier"> Information initiales</param>
        public Form_TrouveEmploi(DemandeurEmploi demandeurAModifier)
        {
            InitializeComponent();
            demandeurValeursInitials = new DemandeurEmploi(demandeurAModifier);
            demandeurModifie = new DemandeurEmploi(demandeurAModifier);
            InitialisationDemandeur();
        }

        /// <summary>
        /// Désactive les validations pour permettre la fermeture de la fenetre avec la croix
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10)
            {
                AutoValidate = AutoValidate.Disable;
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Demande la confimation pour commencer les modifications des information et active les boutons nécéssaires.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Modifier_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez vous modifier les informations de ce demandeur d'emploi ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                textBox_Nom.Enabled = true;
                textBox_DateInscription.Enabled = true;
                groupBox_Niveau.Enabled = true;
                button_Valider.Enabled = true;
                button_Annuler.Enabled = true;
            }

        }

        /// <summary>
        /// Affiche une confimation des changements effectués et mets à jour l'objet correspondant au demandeur d'emploi
        /// Vérifie également que les informations soient correctes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Valider_Click(object sender, EventArgs e)
        {
            EnumNiveauFormation niveau;
            string niveauAcquis = "";
            if (radioButton_Bac.Checked == true)
            {
                niveau = EnumNiveauFormation.Bac;
                niveauAcquis = "Bac";
            }
            else if (radioButton_BacPlus2.Checked == true)
            {
                niveau = EnumNiveauFormation.BacPlus2;
                niveauAcquis = "Bac + 2";
            }
            else if (radioButton_BacPlus5.Checked == true)
            {
                niveau = EnumNiveauFormation.BacPlus5;
                niveauAcquis = "Bac + 5";
            }
            else if (radioButton_SupBacPlus5.Checked == true)
            {
                niveau = EnumNiveauFormation.SupBacPlus5;
                niveauAcquis = "Supérieur Bac + 5";
            }
            else
            {
                niveau = EnumNiveauFormation.InfBac;
                niveauAcquis = "Inférieur Bac";
            }
            if (this.ValidateChildren())
            {
                DialogResult dr = MessageBox.Show("Confirmer vous la modification des information du demandeur d'emploi ?\n" +
                                                  "\n" +
                                                  "Nouvelles informations :\n\n" +
                                                  $"Nom : {textBox_Nom.Text}\n" +
                                                  $"Date d'inscription : {textBox_DateInscription.Text}\n" +
                                                  $"Niveau de formation (Maximum acquis) : {niveauAcquis}\n", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    
                    demandeurModifie = new DemandeurEmploi(textBox_Nom.Text, dateValidee, niveau);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez corriger les erreurs sur le formulaire.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Affiche une confirmation pour la remise à zero des information du demandeur d'emploi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Annuler_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez vous annuler les modification d'informations ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                InitialisationDemandeur();
                demandeurModifie = new DemandeurEmploi(demandeurValeursInitials);
                textBox_Nom.Enabled = false;
                textBox_DateInscription.Enabled = false;
                groupBox_Niveau.Enabled = false;
                button_Valider.Enabled = false;
                button_Annuler.Enabled = false;
            }
        }

        /// <summary>
        /// Vérifie la validité du nom et affiche les erreurs correspondantes le cas échéant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Nom_Validating(object sender, CancelEventArgs e)
        {
            string nom = textBox_Nom.Text;
            string erreur = string.Empty;
            if (RegleValidation.IsStartingSpace(nom)
                || RegleValidation.IsEndingSpace(nom)
                || RegleValidation.IsEmpty(nom))
            {
                erreur = "Le nom ne peut être vide ou commencer/se terminer par un espace";
            }
            else if (RegleValidation.IsNameNotAlphabetic(nom))
            {
                erreur = "Le nom ne doit contenir que des caratères alphabétiques ou tiret, appostrophe, espace";
            }
            else if (RegleValidation.IsNameLessThan2(nom)
                    || RegleValidation.IsMoreThan20(nom))
            {
                erreur = "Le nom doit contenir entre 2 et 20 caractères";
            }
            AfficherErreur(textBox_Nom, errorProvider_Nom, erreur, e);
        }

        /// <summary>
        /// Vérifie la date d'inscription et affiche les erreurs correspondantes le cas échéant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_DateInscription_Validating(object sender, CancelEventArgs e)
        {
            string date = textBox_DateInscription.Text;
            string erreur = string.Empty;
            if (RegleValidation.IsStartingSpace(date)
                || RegleValidation.IsEndingSpace(date)
                || RegleValidation.IsEmpty(date))
            {
                erreur = "La date ne peut être vide ou commencer/se terminer par un espace";
            }
            else if (!RegleValidation.IsDateFormatValid(date, out dateValidee))
            {
                erreur = "Vous devez renseigner une date valide";
            }
            else if (RegleValidation.IsDateInFutur(dateValidee))
            {
                erreur = "La date ne peut être dans le futur";
            }
            AfficherErreur(textBox_DateInscription, errorProvider_Date, erreur, e);
        }

        /// <summary>
        /// Mets à jour l'interface avec les informations par défaut du demandeur d'emploi
        /// </summary>
        private void InitialisationDemandeur()
        {
            textBox_Nom.Text = demandeurValeursInitials.Nom;
            textBox_DateInscription.Text = demandeurValeursInitials.DateInsciption.ToShortDateString();
            switch (demandeurValeursInitials.NiveauFormationMax)
            {
                case EnumNiveauFormation.InfBac:
                    radioButton_InfBac.Checked = true;
                    break;
                case EnumNiveauFormation.Bac:
                    radioButton_Bac.Checked = true;
                    break;
                case EnumNiveauFormation.BacPlus2:
                    radioButton_BacPlus2.Checked = true;
                    break;
                case EnumNiveauFormation.BacPlus5:
                    radioButton_BacPlus5.Checked = true;
                    break;
                case EnumNiveauFormation.SupBacPlus5:
                    radioButton_SupBacPlus5.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Affiche les erreur dans les errorProvider correspondant
        /// </summary>
        /// <param name="controle"> Sur quel control afficher l'errorProvider </param>
        /// <param name="provider"> Selection de l'errorProvider </param>
        /// <param name="messageErreur"> Message d'erreur à afficher </param>
        /// <param name="e"></param>
        private static void AfficherErreur(Control controle, ErrorProvider provider, string messageErreur, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(messageErreur))
            {
                e.Cancel = true;
                provider.SetError(controle, messageErreur);
            }
            else
            {
                provider.SetError(controle, string.Empty);
            }
        }
    }
}
