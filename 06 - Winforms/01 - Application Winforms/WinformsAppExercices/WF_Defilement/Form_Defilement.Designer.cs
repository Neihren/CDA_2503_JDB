namespace WF_Defilement
{
    partial class Form_Defilement
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
            label_Red = new Label();
            label_Green = new Label();
            label_Blue = new Label();
            label_ColorRed = new Label();
            label_ColorGreen = new Label();
            label_ColorBlue = new Label();
            hScrollBar_Red = new HScrollBar();
            numericUpDown_Red = new NumericUpDown();
            hScrollBar_Green = new HScrollBar();
            hScrollBar_Blue = new HScrollBar();
            numericUpDown_Green = new NumericUpDown();
            numericUpDown_Blue = new NumericUpDown();
            label_Mix = new Label();
            button_valider = new Button();
            button_Annuler = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Blue).BeginInit();
            SuspendLayout();
            // 
            // label_Red
            // 
            label_Red.AutoSize = true;
            label_Red.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Red.Location = new Point(30, 36);
            label_Red.Name = "label_Red";
            label_Red.Size = new Size(55, 21);
            label_Red.TabIndex = 0;
            label_Red.Text = "Rouge";
            // 
            // label_Green
            // 
            label_Green.AutoSize = true;
            label_Green.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Green.Location = new Point(30, 75);
            label_Green.Name = "label_Green";
            label_Green.Size = new Size(38, 21);
            label_Green.TabIndex = 1;
            label_Green.Text = "Vert";
            // 
            // label_Blue
            // 
            label_Blue.AutoSize = true;
            label_Blue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Blue.Location = new Point(30, 115);
            label_Blue.Name = "label_Blue";
            label_Blue.Size = new Size(40, 21);
            label_Blue.TabIndex = 2;
            label_Blue.Text = "Bleu";
            // 
            // label_ColorRed
            // 
            label_ColorRed.AutoSize = true;
            label_ColorRed.BackColor = Color.Black;
            label_ColorRed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ColorRed.Location = new Point(368, 40);
            label_ColorRed.MinimumSize = new Size(60, 20);
            label_ColorRed.Name = "label_ColorRed";
            label_ColorRed.Size = new Size(60, 21);
            label_ColorRed.TabIndex = 3;
            // 
            // label_ColorGreen
            // 
            label_ColorGreen.AutoSize = true;
            label_ColorGreen.BackColor = Color.Black;
            label_ColorGreen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ColorGreen.Location = new Point(368, 78);
            label_ColorGreen.MinimumSize = new Size(60, 20);
            label_ColorGreen.Name = "label_ColorGreen";
            label_ColorGreen.Size = new Size(60, 21);
            label_ColorGreen.TabIndex = 4;
            // 
            // label_ColorBlue
            // 
            label_ColorBlue.AutoSize = true;
            label_ColorBlue.BackColor = Color.Black;
            label_ColorBlue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ColorBlue.Location = new Point(368, 119);
            label_ColorBlue.MinimumSize = new Size(60, 20);
            label_ColorBlue.Name = "label_ColorBlue";
            label_ColorBlue.Size = new Size(60, 21);
            label_ColorBlue.TabIndex = 5;
            // 
            // hScrollBar_Red
            // 
            hScrollBar_Red.Location = new Point(98, 40);
            hScrollBar_Red.Maximum = 264;
            hScrollBar_Red.Name = "hScrollBar_Red";
            hScrollBar_Red.Size = new Size(170, 17);
            hScrollBar_Red.TabIndex = 6;
            hScrollBar_Red.ValueChanged += HScrollBar_Red_ValueChanged;
            // 
            // numericUpDown_Red
            // 
            numericUpDown_Red.Location = new Point(282, 39);
            numericUpDown_Red.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown_Red.Name = "numericUpDown_Red";
            numericUpDown_Red.Size = new Size(71, 23);
            numericUpDown_Red.TabIndex = 7;
            numericUpDown_Red.ValueChanged += NumericUpDown_Red_ValueChanged;
            // 
            // hScrollBar_Green
            // 
            hScrollBar_Green.Location = new Point(98, 79);
            hScrollBar_Green.Maximum = 264;
            hScrollBar_Green.Name = "hScrollBar_Green";
            hScrollBar_Green.Size = new Size(170, 17);
            hScrollBar_Green.TabIndex = 8;
            hScrollBar_Green.ValueChanged += HScrollBar_Vert_ValueChanged;
            // 
            // hScrollBar_Blue
            // 
            hScrollBar_Blue.Location = new Point(98, 119);
            hScrollBar_Blue.Maximum = 264;
            hScrollBar_Blue.Name = "hScrollBar_Blue";
            hScrollBar_Blue.Size = new Size(170, 17);
            hScrollBar_Blue.TabIndex = 9;
            hScrollBar_Blue.ValueChanged += HScrollBar_Blue_ValueChanged;
            // 
            // numericUpDown_Green
            // 
            numericUpDown_Green.Location = new Point(282, 78);
            numericUpDown_Green.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown_Green.Name = "numericUpDown_Green";
            numericUpDown_Green.Size = new Size(71, 23);
            numericUpDown_Green.TabIndex = 10;
            numericUpDown_Green.ValueChanged += NumericUpDown_Green_ValueChanged;
            // 
            // numericUpDown_Blue
            // 
            numericUpDown_Blue.Location = new Point(282, 118);
            numericUpDown_Blue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown_Blue.Name = "numericUpDown_Blue";
            numericUpDown_Blue.Size = new Size(71, 23);
            numericUpDown_Blue.TabIndex = 11;
            numericUpDown_Blue.ValueChanged += NumericUpDown_Blue_ValueChanged;
            // 
            // label_Mix
            // 
            label_Mix.AutoSize = true;
            label_Mix.BackColor = Color.Black;
            label_Mix.Location = new Point(30, 153);
            label_Mix.MinimumSize = new Size(380, 80);
            label_Mix.Name = "label_Mix";
            label_Mix.Size = new Size(380, 80);
            label_Mix.TabIndex = 12;
            // 
            // button_valider
            // 
            button_valider.DialogResult = DialogResult.OK;
            button_valider.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_valider.Location = new Point(98, 240);
            button_valider.Name = "button_valider";
            button_valider.Size = new Size(75, 33);
            button_valider.TabIndex = 13;
            button_valider.Text = "Valider";
            button_valider.UseVisualStyleBackColor = true;
            button_valider.Click += button_valider_Click;
            // 
            // button_Annuler
            // 
            button_Annuler.DialogResult = DialogResult.Cancel;
            button_Annuler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Annuler.Location = new Point(263, 240);
            button_Annuler.Name = "button_Annuler";
            button_Annuler.Size = new Size(75, 33);
            button_Annuler.TabIndex = 14;
            button_Annuler.Text = "Annuler";
            button_Annuler.UseVisualStyleBackColor = true;
            button_Annuler.Click += button_Annuler_Click;
            // 
            // Form_Defilement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 285);
            Controls.Add(button_Annuler);
            Controls.Add(button_valider);
            Controls.Add(label_Mix);
            Controls.Add(numericUpDown_Blue);
            Controls.Add(numericUpDown_Green);
            Controls.Add(hScrollBar_Blue);
            Controls.Add(hScrollBar_Green);
            Controls.Add(numericUpDown_Red);
            Controls.Add(hScrollBar_Red);
            Controls.Add(label_ColorBlue);
            Controls.Add(label_ColorGreen);
            Controls.Add(label_ColorRed);
            Controls.Add(label_Blue);
            Controls.Add(label_Green);
            Controls.Add(label_Red);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_Defilement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Red).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Green).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Blue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Red;
        private Label label_Green;
        private Label label_Blue;
        private Label label_ColorRed;
        private Label label_ColorGreen;
        private Label label_ColorBlue;
        private HScrollBar hScrollBar_Red;
        private NumericUpDown numericUpDown_Red;
        private HScrollBar hScrollBar_Green;
        private HScrollBar hScrollBar_Blue;
        private NumericUpDown numericUpDown_Green;
        private NumericUpDown numericUpDown_Blue;
        private Label label_Mix;
        private Button button_valider;
        private Button button_Annuler;
    }
}
