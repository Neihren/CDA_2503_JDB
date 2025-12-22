namespace WinformsAppCalculatrice
{
    public partial class FormCalculatrice : Form
    {
        public FormCalculatrice()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "C'est Ok";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
