namespace WF_Defilement
{
    public partial class Form_Defilement : Form
    {

        Color couleurConfigure;
        Color couleurInitiale;

        public Color CouleurConfigure { get => couleurConfigure; }

        public Form_Defilement() : this(Color.Black)
        {
        }

        public Form_Defilement(Color colorAModifier)
        {
            InitializeComponent();
            couleurInitiale = colorAModifier;
            couleurConfigure = colorAModifier;
            UpdateView();
        }

        void UpdateView()
        {
            this.hScrollBar_Red.Value = couleurConfigure.R;
            this.numericUpDown_Red.Value = couleurConfigure.R;
            this.hScrollBar_Green.Value = couleurConfigure.G;
            this.numericUpDown_Green.Value = couleurConfigure.G;
            this.hScrollBar_Blue.Value = couleurConfigure.B;
            this.numericUpDown_Blue.Value = couleurConfigure.B;
            this.label_ColorRed.BackColor = Color.FromArgb(couleurConfigure.R, 0, 0);
            this.label_ColorGreen.BackColor = Color.FromArgb(0, couleurConfigure.G, 0);
            this.label_ColorBlue.BackColor = Color.FromArgb(0, 0, couleurConfigure.B);
            this.label_Mix.BackColor = couleurConfigure;
        }

        private void HScrollBar_Red_ValueChanged(object sender, EventArgs e)
        {
            couleurConfigure = Color.FromArgb(hScrollBar_Red.Value, couleurConfigure.G, couleurConfigure.B);
            UpdateView();
        }

        private void NumericUpDown_Red_ValueChanged(object sender, EventArgs e)
        {
            couleurConfigure = Color.FromArgb((int)numericUpDown_Red.Value, couleurConfigure.G, couleurConfigure.B);
            UpdateView();
        }

        private void HScrollBar_Vert_ValueChanged(object sender, EventArgs e)
        {
            couleurConfigure = Color.FromArgb(couleurConfigure.R, hScrollBar_Green.Value, couleurConfigure.B);
            UpdateView();
        }

        private void NumericUpDown_Green_ValueChanged(object sender, EventArgs e)
        {
            couleurConfigure = Color.FromArgb(couleurConfigure.R, (int)numericUpDown_Green.Value, couleurConfigure.B);
            UpdateView();
        }

        private void HScrollBar_Blue_ValueChanged(object sender, EventArgs e)
        {
            couleurConfigure = Color.FromArgb(couleurConfigure.R, couleurConfigure.G, hScrollBar_Blue.Value);
            UpdateView();
        }

        private void NumericUpDown_Blue_ValueChanged(object sender, EventArgs e)
        {
            couleurConfigure = Color.FromArgb(couleurConfigure.R, couleurConfigure.G, (int)numericUpDown_Blue.Value);
            UpdateView();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            couleurConfigure = couleurInitiale;
            this.Close();
        }
    }
}
