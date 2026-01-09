namespace WF_CheckBoxEtRadioButton
{
    public partial class Form_CBRB : Form
    {
        public Form_CBRB()
        {
            InitializeComponent();
        }

        private void TextBox_input_TextChanged(object sender, EventArgs e)
        {
            if (textBox_input.Text == string.Empty)
            {
                groupBox_Choice.Enabled = false;
                label_Result.Visible = false;
                label_Result.Enabled = false;
                checkBox_BgColor.Checked = false;
                checkBox_TextColor.Checked = false;
                checkBox_Case.Checked = false;
            }
            else if (textBox_input.Text != string.Empty)
            {
                groupBox_Choice.Enabled = true;
                label_Result.Visible = true;
                label_Result.Enabled = true;
                if (radioButton_CaseUpper.Checked == true)
                {
                    label_Result.Text = textBox_input.Text.ToUpper();
                }
                else if (radioButton_CaseLower.Checked == true)
                {
                    label_Result.Text = textBox_input.Text.ToLower();
                }
                else
                {
                    label_Result.Text = textBox_input.Text;
                }
            }
        }

        private void CheckBox_BgColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_BgColor.Checked == true)
            {
                groupBox_BgColor.Visible = true;
                groupBox_BgColor.Enabled = true;
            }
            else
            {
                groupBox_BgColor.Visible = false;
                groupBox_BgColor.Enabled = false;
            }
        }

        private void GroupBox_BgColor_VisibleChanged(object sender, EventArgs e)
        {
            if (groupBox_BgColor.Visible == false)
            {
                radioButton_BgRed.Checked = false;
                radioButton_BgGreen.Checked = false;
                radioButton_BgBlue.Checked = false;
                label_Result.BackColor = SystemColors.Control;
            }
        }

        private void RadioButton_BgRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_BgRed.Checked == true)
            {
                label_Result.BackColor = Color.Red;
            }
        }

        private void RadioButton_BgGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_BgGreen.Checked == true)
            {
                label_Result.BackColor = Color.Green;
            }
        }

        private void RadioButton_BgBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_BgBlue.Checked == true)
            {
                label_Result.BackColor = Color.Blue;
            }
        }

        private void CheckBox_TextColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TextColor.Checked == true)
            {
                groupBox_TextColor.Visible = true;
                groupBox_TextColor.Enabled = true;
            }
            else
            {
                groupBox_TextColor.Visible = false;
                groupBox_TextColor.Enabled = false;
            }
        }

        private void GroupBox_TextColor_VisibleChanged(object sender, EventArgs e)
        {
            if (groupBox_TextColor.Visible == false)
            {
                radioButton_TextColorRed.Checked = false;
                radioButton_TextColorWhite.Checked = false;
                radioButton_TextColorBlack.Checked = false;
                label_Result.ForeColor = SystemColors.ControlText;
            }
        }

        private void RadioButton_TextColorRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_TextColorRed.Checked == true)
            {
                label_Result.ForeColor = Color.Red;
            }
        }

        private void RadioButton_TextColorWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_TextColorWhite.Checked == true)
            {
                label_Result.ForeColor = Color.White;
            }
        }

        private void RadioButton_TextColorBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_TextColorBlack.Checked == true)
            {
                label_Result.ForeColor = Color.Black;
            }
        }

        private void CheckBox_Case_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Case.Checked == true)
            {
                groupBox_Case.Visible = true;
                groupBox_Case.Enabled = true;
            }
            else
            {
                groupBox_Case.Visible = false;
                groupBox_Case.Enabled = false;

            }
        }

        private void GroupBox_Case_VisibleChanged(object sender, EventArgs e)
        {
            if (groupBox_Case.Visible == false)
            {
                radioButton_CaseUpper.Checked = false;
                radioButton_CaseLower.Checked = false;
                label_Result.Text = textBox_input.Text;
            }
        }

        private void RadioButton_CaseLower_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_CaseLower.Checked == true)
            {
                label_Result.Text = label_Result.Text.ToLower();
            }
        }

        private void RadioButton_CaseUpper_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_CaseUpper.Checked == true)
            {
                label_Result.Text = label_Result.Text.ToUpper();
            }
        }
    }
}
