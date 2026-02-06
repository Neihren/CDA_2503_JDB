using WF_Additionneur;

namespace WF_Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void LAdditionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Additionneur additionneur = new Additionneur();
            additionneur.MdiParent = this;
            additionneur.Show();
        }

        private void SidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            phase1ToolStripMenuItem.Enabled = true;
            phase2ToolStripMenuItem.Enabled = true;
            phase3ToolStripMenuItem.Enabled = true;
            fenetresToolStripMenuItem.Enabled = true;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
