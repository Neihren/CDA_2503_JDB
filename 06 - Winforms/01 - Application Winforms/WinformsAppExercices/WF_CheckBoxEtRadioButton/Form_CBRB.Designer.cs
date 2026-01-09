namespace WF_CheckBoxEtRadioButton
{
    partial class Form_CBRB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_input = new TextBox();
            label_Instruction = new Label();
            groupBox_Choice = new GroupBox();
            checkBox_Case = new CheckBox();
            checkBox_TextColor = new CheckBox();
            checkBox_BgColor = new CheckBox();
            groupBox_BgColor = new GroupBox();
            radioButton_BgBlue = new RadioButton();
            radioButton_BgGreen = new RadioButton();
            radioButton_BgRed = new RadioButton();
            groupBox_TextColor = new GroupBox();
            radioButton_TextColorBlack = new RadioButton();
            radioButton_TextColorWhite = new RadioButton();
            radioButton_TextColorRed = new RadioButton();
            groupBox_Case = new GroupBox();
            radioButton_CaseUpper = new RadioButton();
            radioButton_CaseLower = new RadioButton();
            label_Result = new Label();
            groupBox_Choice.SuspendLayout();
            groupBox_BgColor.SuspendLayout();
            groupBox_TextColor.SuspendLayout();
            groupBox_Case.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_input
            // 
            textBox_input.Location = new Point(30, 37);
            textBox_input.Name = "textBox_input";
            textBox_input.Size = new Size(200, 23);
            textBox_input.TabIndex = 0;
            textBox_input.TextChanged += TextBox_input_TextChanged;
            // 
            // label_Instruction
            // 
            label_Instruction.AutoSize = true;
            label_Instruction.Location = new Point(30, 9);
            label_Instruction.Name = "label_Instruction";
            label_Instruction.Size = new Size(95, 15);
            label_Instruction.TabIndex = 1;
            label_Instruction.Text = "Tapez votre texte";
            // 
            // groupBox_Choice
            // 
            groupBox_Choice.Controls.Add(checkBox_Case);
            groupBox_Choice.Controls.Add(checkBox_TextColor);
            groupBox_Choice.Controls.Add(checkBox_BgColor);
            groupBox_Choice.Enabled = false;
            groupBox_Choice.Location = new Point(256, 12);
            groupBox_Choice.Name = "groupBox_Choice";
            groupBox_Choice.Size = new Size(165, 100);
            groupBox_Choice.TabIndex = 3;
            groupBox_Choice.TabStop = false;
            groupBox_Choice.Text = "Choix";
            // 
            // checkBox_Case
            // 
            checkBox_Case.AutoSize = true;
            checkBox_Case.Location = new Point(6, 72);
            checkBox_Case.Name = "checkBox_Case";
            checkBox_Case.Size = new Size(56, 19);
            checkBox_Case.TabIndex = 2;
            checkBox_Case.Text = "Casse";
            checkBox_Case.UseVisualStyleBackColor = true;
            checkBox_Case.CheckedChanged += CheckBox_Case_CheckedChanged;
            // 
            // checkBox_TextColor
            // 
            checkBox_TextColor.AutoSize = true;
            checkBox_TextColor.Location = new Point(6, 47);
            checkBox_TextColor.Name = "checkBox_TextColor";
            checkBox_TextColor.Size = new Size(145, 19);
            checkBox_TextColor.TabIndex = 1;
            checkBox_TextColor.Text = "Couleur des caractères";
            checkBox_TextColor.UseVisualStyleBackColor = true;
            checkBox_TextColor.CheckedChanged += CheckBox_TextColor_CheckedChanged;
            // 
            // checkBox_BgColor
            // 
            checkBox_BgColor.AutoSize = true;
            checkBox_BgColor.Location = new Point(6, 22);
            checkBox_BgColor.Name = "checkBox_BgColor";
            checkBox_BgColor.Size = new Size(113, 19);
            checkBox_BgColor.TabIndex = 0;
            checkBox_BgColor.Text = "Couleur du fond";
            checkBox_BgColor.UseVisualStyleBackColor = true;
            checkBox_BgColor.CheckedChanged += CheckBox_BgColor_CheckedChanged;
            // 
            // groupBox_BgColor
            // 
            groupBox_BgColor.Controls.Add(radioButton_BgBlue);
            groupBox_BgColor.Controls.Add(radioButton_BgGreen);
            groupBox_BgColor.Controls.Add(radioButton_BgRed);
            groupBox_BgColor.Enabled = false;
            groupBox_BgColor.Location = new Point(30, 120);
            groupBox_BgColor.Name = "groupBox_BgColor";
            groupBox_BgColor.Size = new Size(75, 100);
            groupBox_BgColor.TabIndex = 4;
            groupBox_BgColor.TabStop = false;
            groupBox_BgColor.Text = "Fond";
            groupBox_BgColor.Visible = false;
            groupBox_BgColor.VisibleChanged += GroupBox_BgColor_VisibleChanged;
            // 
            // radioButton_BgBlue
            // 
            radioButton_BgBlue.AutoSize = true;
            radioButton_BgBlue.Location = new Point(6, 72);
            radioButton_BgBlue.Name = "radioButton_BgBlue";
            radioButton_BgBlue.Size = new Size(48, 19);
            radioButton_BgBlue.TabIndex = 2;
            radioButton_BgBlue.TabStop = true;
            radioButton_BgBlue.Text = "Bleu";
            radioButton_BgBlue.UseVisualStyleBackColor = true;
            radioButton_BgBlue.CheckedChanged += RadioButton_BgBlue_CheckedChanged;
            // 
            // radioButton_BgGreen
            // 
            radioButton_BgGreen.AutoSize = true;
            radioButton_BgGreen.Location = new Point(6, 47);
            radioButton_BgGreen.Name = "radioButton_BgGreen";
            radioButton_BgGreen.Size = new Size(45, 19);
            radioButton_BgGreen.TabIndex = 1;
            radioButton_BgGreen.TabStop = true;
            radioButton_BgGreen.Text = "Vert";
            radioButton_BgGreen.UseVisualStyleBackColor = true;
            radioButton_BgGreen.CheckedChanged += RadioButton_BgGreen_CheckedChanged;
            // 
            // radioButton_BgRed
            // 
            radioButton_BgRed.AutoSize = true;
            radioButton_BgRed.Location = new Point(6, 22);
            radioButton_BgRed.Name = "radioButton_BgRed";
            radioButton_BgRed.Size = new Size(59, 19);
            radioButton_BgRed.TabIndex = 0;
            radioButton_BgRed.TabStop = true;
            radioButton_BgRed.Text = "Rouge";
            radioButton_BgRed.UseVisualStyleBackColor = true;
            radioButton_BgRed.CheckedChanged += RadioButton_BgRed_CheckedChanged;
            // 
            // groupBox_TextColor
            // 
            groupBox_TextColor.Controls.Add(radioButton_TextColorBlack);
            groupBox_TextColor.Controls.Add(radioButton_TextColorWhite);
            groupBox_TextColor.Controls.Add(radioButton_TextColorRed);
            groupBox_TextColor.Enabled = false;
            groupBox_TextColor.Location = new Point(111, 120);
            groupBox_TextColor.Name = "groupBox_TextColor";
            groupBox_TextColor.Size = new Size(80, 100);
            groupBox_TextColor.TabIndex = 5;
            groupBox_TextColor.TabStop = false;
            groupBox_TextColor.Text = "Caractères";
            groupBox_TextColor.Visible = false;
            groupBox_TextColor.VisibleChanged += GroupBox_TextColor_VisibleChanged;
            // 
            // radioButton_TextColorBlack
            // 
            radioButton_TextColorBlack.AutoSize = true;
            radioButton_TextColorBlack.Location = new Point(6, 72);
            radioButton_TextColorBlack.Name = "radioButton_TextColorBlack";
            radioButton_TextColorBlack.Size = new Size(48, 19);
            radioButton_TextColorBlack.TabIndex = 2;
            radioButton_TextColorBlack.TabStop = true;
            radioButton_TextColorBlack.Text = "Noir";
            radioButton_TextColorBlack.UseVisualStyleBackColor = true;
            radioButton_TextColorBlack.CheckedChanged += RadioButton_TextColorBlack_CheckedChanged;
            // 
            // radioButton_TextColorWhite
            // 
            radioButton_TextColorWhite.AutoSize = true;
            radioButton_TextColorWhite.Location = new Point(6, 47);
            radioButton_TextColorWhite.Name = "radioButton_TextColorWhite";
            radioButton_TextColorWhite.Size = new Size(54, 19);
            radioButton_TextColorWhite.TabIndex = 1;
            radioButton_TextColorWhite.TabStop = true;
            radioButton_TextColorWhite.Text = "Blanc";
            radioButton_TextColorWhite.UseVisualStyleBackColor = true;
            radioButton_TextColorWhite.CheckedChanged += RadioButton_TextColorWhite_CheckedChanged;
            // 
            // radioButton_TextColorRed
            // 
            radioButton_TextColorRed.AutoSize = true;
            radioButton_TextColorRed.Location = new Point(6, 22);
            radioButton_TextColorRed.Name = "radioButton_TextColorRed";
            radioButton_TextColorRed.Size = new Size(59, 19);
            radioButton_TextColorRed.TabIndex = 0;
            radioButton_TextColorRed.TabStop = true;
            radioButton_TextColorRed.Text = "Rouge";
            radioButton_TextColorRed.UseVisualStyleBackColor = true;
            radioButton_TextColorRed.CheckedChanged += RadioButton_TextColorRed_CheckedChanged;
            // 
            // groupBox_Case
            // 
            groupBox_Case.Controls.Add(radioButton_CaseUpper);
            groupBox_Case.Controls.Add(radioButton_CaseLower);
            groupBox_Case.Enabled = false;
            groupBox_Case.Location = new Point(197, 154);
            groupBox_Case.Name = "groupBox_Case";
            groupBox_Case.Size = new Size(100, 66);
            groupBox_Case.TabIndex = 6;
            groupBox_Case.TabStop = false;
            groupBox_Case.Text = "Casse";
            groupBox_Case.Visible = false;
            groupBox_Case.VisibleChanged += GroupBox_Case_VisibleChanged;
            // 
            // radioButton_CaseUpper
            // 
            radioButton_CaseUpper.AutoSize = true;
            radioButton_CaseUpper.Location = new Point(10, 42);
            radioButton_CaseUpper.Name = "radioButton_CaseUpper";
            radioButton_CaseUpper.Size = new Size(84, 19);
            radioButton_CaseUpper.TabIndex = 1;
            radioButton_CaseUpper.TabStop = true;
            radioButton_CaseUpper.Text = "Majuscules";
            radioButton_CaseUpper.UseVisualStyleBackColor = true;
            radioButton_CaseUpper.CheckedChanged += RadioButton_CaseUpper_CheckedChanged;
            // 
            // radioButton_CaseLower
            // 
            radioButton_CaseLower.AutoSize = true;
            radioButton_CaseLower.CheckAlign = ContentAlignment.TopLeft;
            radioButton_CaseLower.Location = new Point(9, 20);
            radioButton_CaseLower.Name = "radioButton_CaseLower";
            radioButton_CaseLower.Size = new Size(85, 19);
            radioButton_CaseLower.TabIndex = 0;
            radioButton_CaseLower.TabStop = true;
            radioButton_CaseLower.Text = "Minuscules";
            radioButton_CaseLower.UseVisualStyleBackColor = true;
            radioButton_CaseLower.CheckedChanged += RadioButton_CaseLower_CheckedChanged;
            // 
            // label_Result
            // 
            label_Result.AutoSize = true;
            label_Result.Location = new Point(30, 84);
            label_Result.Name = "label_Result";
            label_Result.Size = new Size(0, 15);
            label_Result.TabIndex = 7;
            // 
            // Form_CBRB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 237);
            Controls.Add(label_Result);
            Controls.Add(groupBox_Case);
            Controls.Add(groupBox_TextColor);
            Controls.Add(groupBox_BgColor);
            Controls.Add(groupBox_Choice);
            Controls.Add(label_Instruction);
            Controls.Add(textBox_input);
            MaximizeBox = false;
            Name = "Form_CBRB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckBox et RadioButton";
            groupBox_Choice.ResumeLayout(false);
            groupBox_Choice.PerformLayout();
            groupBox_BgColor.ResumeLayout(false);
            groupBox_BgColor.PerformLayout();
            groupBox_TextColor.ResumeLayout(false);
            groupBox_TextColor.PerformLayout();
            groupBox_Case.ResumeLayout(false);
            groupBox_Case.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_input;
        private Label label_Instruction;
        private GroupBox groupBox_Choice;
        private CheckBox checkBox_BgColor;
        private CheckBox checkBox_TextColor;
        private CheckBox checkBox_Case;
        private GroupBox groupBox_BgColor;
        private GroupBox groupBox_TextColor;
        private GroupBox groupBox_Case;
        private RadioButton radioButton_BgBlue;
        private RadioButton radioButton_BgGreen;
        private RadioButton radioButton_BgRed;
        private RadioButton radioButton_TextColorBlack;
        private RadioButton radioButton_TextColorWhite;
        private RadioButton radioButton_TextColorRed;
        private RadioButton radioButton_CaseUpper;
        private RadioButton radioButton_CaseLower;
        private Label label_Result;
    }
}
