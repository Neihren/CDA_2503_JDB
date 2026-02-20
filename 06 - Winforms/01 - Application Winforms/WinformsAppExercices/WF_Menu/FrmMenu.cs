using _01_WF_ControlesEP;
using WF_Additionneur;
using WF_CheckBoxEtRadioButton;
using WF_Defilement;
using WF_Emprunts;
using WF_ListeCombo;

namespace WF_Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            UpdateDate();
            timer1.Interval = 1000;
            timer1.Tick += (sender, e) => UpdateDate();
            timer1.Start();
            this.toolStripStatusLabel_App.Text = "";
        }

        private void UpdateDate()
        {
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            if (toolStripStatusLabel_Date.Text != currentDate)
            {
                toolStripStatusLabel_Date.Text = currentDate;
            }
        }

        private void SidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            phase1ToolStripMenuItem.Enabled = true;
            phase2ToolStripMenuItem.Enabled = true;
            phase3ToolStripMenuItem.Enabled = true;
            fenetresToolStripMenuItem.Enabled = true;
            toolStripSplitButton1.Enabled = true;
            toolStripStatusLabel_App.Text = "S'identifier";
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Fin de l'application",
                                                "FIN",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LAdditionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Additionneur additionneur = new();
            additionneur.MdiParent = this;
            additionneur.Show();
            toolStripStatusLabel_App.Text = additionneur.Text;
        }

        private void ControlesDeSaisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 controlesDeSaisie = new();
            controlesDeSaisie.MdiParent = this;
            controlesDeSaisie.Show();
            toolStripStatusLabel_App.Text = controlesDeSaisie.Text;
        }

        private void CasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Saisie saisie = new();
            saisie.MdiParent = this;
            saisie.Show();
            //saisie.InputValidated += (s, args) =>
            //{
            //    Form_CBRB form_CBRB = new Form_CBRB(saisie.Input);
            //    form_CBRB.MdiParent = this;
            //    form_CBRB.Show();
            //};
            saisie.InputWithInformations += Saisie_InputWithInformations;
            toolStripStatusLabel_App.Text = saisie.Text;
        }

        private void Saisie_InputWithInformations(object? sender, InputEventArgs e)
        {
            Form_CBRB form_CBRB = new Form_CBRB(e.Input);
            form_CBRB.MdiParent = this;
            form_CBRB.Show();
        }

        private void ComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeCombo combo = new();
            combo.MdiParent = this;
            combo.Show();
            toolStripStatusLabel_App.Text = combo.Text;
        }

        private void DéfilementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Defilement defilement = new();
            defilement.MdiParent = this;
            defilement.Show();
            toolStripStatusLabel_App.Text = defilement.Text;
        }

        private void SynthèseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmprunts emprunts = new();
            emprunts.MdiParent = this;
            emprunts.Show();
            toolStripStatusLabel_App.Text = emprunts.Text;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cascadeToolStripMenuItem.Checked = true;
            horizontalToolStripMenuItem.Checked = false;
            verticalToolStripMenuItem.Checked = false;
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void HorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cascadeToolStripMenuItem.Checked = false;
            horizontalToolStripMenuItem.Checked = true;
            verticalToolStripMenuItem.Checked = false;
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void VerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cascadeToolStripMenuItem.Checked = false;
            horizontalToolStripMenuItem.Checked = false;
            verticalToolStripMenuItem.Checked = true;
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
