using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Additionneur;
using WF_CheckBoxEtRadioButton;

namespace WF_Menu
{
    public partial class Form_Saisie : Form
    {
        private string input;
        public Form_Saisie()
        {
            InitializeComponent();
        }

        public string Input { get => input; set => input = value; }

        public event EventHandler? InputValidated;
        public event EventHandler<InputEventArgs>? InputWithInformations;

        private void Button_Valider_Click(object sender, EventArgs e)
        {
            input = textBox_Text.Text;
            if (InputValidated != null)
            {
                InputValidated(this, new EventArgs());
            }
            if (InputWithInformations != null)
            {
                InputWithInformations(this, new InputEventArgs(input));
            }
            this.Close();
        }
    }
}
