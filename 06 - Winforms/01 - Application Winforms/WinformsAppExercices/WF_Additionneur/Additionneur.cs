using System.Dynamic;

namespace WF_Additionneur
{
    public partial class Additionneur : Form
    {
        private int sum;
        public Additionneur()
        {
            InitializeComponent();
            this.sum = 0;
        }
        /// <summary>
        /// Methode ayant en paramètre le bouton cliqué pour ajouter le chiffre correspondant au bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nb_click(object sender, EventArgs e)
        {
            Button? btn = sender as Button;
            if (btn != null)
            {
                this.textBox_calcul.Text += btn.Text + "+";
                this.sum += int.Parse(btn.Text);
            }
        }

        /// <summary>
        /// Methode pour le bouton supprimer qui vide l'attribut sum et la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_suppr_Click(object sender, EventArgs e)
        {
            this.textBox_calcul.Text = "";
            this.sum = 0;
        }

        /// <summary>
        /// Methode pour afficher la somme du calcul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_calcul_Click(object sender, EventArgs e)
        {
            this.textBox_calcul.Text += " = " + this.sum + "+";
        }
    }
}
