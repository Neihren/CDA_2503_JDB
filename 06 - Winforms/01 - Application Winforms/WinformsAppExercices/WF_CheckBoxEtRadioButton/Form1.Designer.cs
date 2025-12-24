namespace WF_CheckBoxEtRadioButton
{
    partial class Form1
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
            textBox_result = new TextBox();
            groupBox_Choice = new GroupBox();
            checkBox_Case = new CheckBox();
            checkBox_TextColor = new CheckBox();
            checkBox_BgColor = new CheckBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox3 = new GroupBox();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            groupBox_Choice.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_input
            // 
            textBox_input.Location = new Point(30, 37);
            textBox_input.Name = "textBox_input";
            textBox_input.Size = new Size(200, 23);
            textBox_input.TabIndex = 0;
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
            // textBox_result
            // 
            textBox_result.Location = new Point(30, 80);
            textBox_result.Name = "textBox_result";
            textBox_result.Size = new Size(200, 23);
            textBox_result.TabIndex = 2;
            // 
            // groupBox_Choice
            // 
            groupBox_Choice.Controls.Add(checkBox_Case);
            groupBox_Choice.Controls.Add(checkBox_TextColor);
            groupBox_Choice.Controls.Add(checkBox_BgColor);
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(30, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(75, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fond";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(48, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Bleu";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Vert";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Rouge";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(111, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(80, 100);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Caractères";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 72);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(48, 19);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "Noir";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 47);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(54, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Blanc";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(59, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Rouge";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton8);
            groupBox3.Controls.Add(radioButton7);
            groupBox3.Location = new Point(485, 204);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Casse";
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(10, 42);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(84, 19);
            radioButton8.TabIndex = 1;
            radioButton8.TabStop = true;
            radioButton8.Text = "Majuscules";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.CheckAlign = ContentAlignment.TopLeft;
            radioButton7.Location = new Point(9, 20);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(85, 19);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "Minuscules";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox_Choice);
            Controls.Add(textBox_result);
            Controls.Add(label_Instruction);
            Controls.Add(textBox_input);
            Name = "Form1";
            Text = "CheckBox et RadioButton";
            groupBox_Choice.ResumeLayout(false);
            groupBox_Choice.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_input;
        private Label label_Instruction;
        private TextBox textBox_result;
        private GroupBox groupBox_Choice;
        private CheckBox checkBox_BgColor;
        private CheckBox checkBox_TextColor;
        private CheckBox checkBox_Case;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
    }
}
